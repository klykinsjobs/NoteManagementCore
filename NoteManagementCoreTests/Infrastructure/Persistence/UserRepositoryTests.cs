using NoteManagementCore.Domain.Entities;
using NoteManagementCore.Domain.Enums;
using NoteManagementCore.Infrastructure.Persistence;
using NoteManagementCoreTests.Integration.TestHelpers;

namespace NoteManagementCoreTests.Infrastructure.Persistence
{
    public class UserRepositoryTests
    {
        [Fact]
        public async Task GetByIdAsync_ShouldThrow_WhenIdIsInvalid()
        {
            using var db = DbFactory.CreateDb();
            var repo = new UserRepository(db);

            Task act() => repo.GetByIdAsync(0);

            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(act);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnUser_WhenUserExists()
        {
            using var db = DbFactory.CreateDb();
            var repo = new UserRepository(db);

            var user = new User { Username = "alice", PasswordHash = "x" };
            db.Users.Add(user);
            await db.SaveChangesAsync(TestContext.Current.CancellationToken);

            var result = await repo.GetByIdAsync(user.Id);

            Assert.NotNull(result);
            Assert.Equal("alice", result!.Username);
        }

        [Fact]
        public async Task GetByUsernameAsync_ShouldThrow_WhenUsernameIsEmpty()
        {
            using var db = DbFactory.CreateDb();
            var repo = new UserRepository(db);

            Task act() => repo.GetByUsernameAsync("");

            await Assert.ThrowsAsync<ArgumentException>(act);
        }

        [Fact]
        public async Task UsernameExistsAsync_ShouldReturnTrue_WhenUserExists()
        {
            using var db = DbFactory.CreateDb();
            var repo = new UserRepository(db);

            db.Users.Add(new User { Username = "bob", PasswordHash = "x" });
            await db.SaveChangesAsync(TestContext.Current.CancellationToken);

            var exists = await repo.UsernameExistsAsync("bob");

            Assert.True(exists);
        }

        [Fact]
        public async Task AddAsync_ShouldAddUser()
        {
            using var db = DbFactory.CreateDb();
            var repo = new UserRepository(db);

            var user = new User { Username = "alice", PasswordHash = "x", Role = Role.Admin };

            await repo.AddAsync(user);

            Assert.Contains(db.Users, u => u.Username == "alice");
        }

        [Fact]
        public async Task UpdateAsync_ShouldUpdateUser()
        {
            using var db = DbFactory.CreateDb();
            var repo = new UserRepository(db);

            var user = new User { Username = "bob", PasswordHash = "x" };
            db.Users.Add(user);
            await db.SaveChangesAsync(TestContext.Current.CancellationToken);

            user.Username = "bob2";

            await repo.UpdateAsync(user);

            Assert.Equal("bob2", db.Users.First().Username);
        }

        [Fact]
        public async Task DeleteAsync_ShouldRemoveUser_WhenUserExists()
        {
            using var db = DbFactory.CreateDb();
            var repo = new UserRepository(db);

            var user = new User { Username = "alice", PasswordHash = "x" };
            db.Users.Add(user);
            await db.SaveChangesAsync(TestContext.Current.CancellationToken);

            await repo.DeleteAsync(user.Id);

            Assert.Empty(db.Users);
        }

        [Fact]
        public async Task DeleteAsync_ShouldDoNothing_WhenUserNotFound()
        {
            using var db = DbFactory.CreateDb();
            var repo = new UserRepository(db);

            await repo.DeleteAsync(999);

            Assert.Empty(db.Users);
        }
    }
}
using NoteManagementCore.Application.Services;
using NoteManagementCore.Domain.Entities;
using NoteManagementCore.Infrastructure.Persistence;
using NoteManagementCoreTests.Integration.TestHelpers;

namespace NoteManagementCoreTests.Integration
{
    public class NoteServiceIntegrationTests
    {
        [Fact]
        public async Task AddAndRetrieveNotes_ShouldWorkCorrectly()
        {
            using var db = DbFactory.CreateDb();

            var user = new User { Username = "bob", PasswordHash = "x" };
            db.Users.Add(user);
            await db.SaveChangesAsync(TestContext.Current.CancellationToken);

            var noteRepo = new NoteRepository(db);
            var service = new NoteService(noteRepo);

            await service.AddAsync("title", "content", user.Id);

            var notes = await service.GetAllAsync();

            var item = Assert.Single(notes);
            Assert.Equal("title", item.Title);
            Assert.Equal("bob", item.LastUpdatedBy);
        }

        [Fact]
        public async Task UpdateNote_ShouldPersistChanges()
        {
            using var db = DbFactory.CreateDb();

            var user = new User { Username = "bob", PasswordHash = "x" };
            db.Users.Add(user);

            var note = new Note { Title = "title", Content = "content", LastUpdatedByUserId = user.Id };
            db.Notes.Add(note);

            await db.SaveChangesAsync(TestContext.Current.CancellationToken);

            var repo = new NoteRepository(db);
            var service = new NoteService(repo);

            await service.UpdateAsync(note.Id, "title2", "content2", user.Id);

            var updated = db.Notes.First();

            Assert.Equal("title2", updated.Title);
            Assert.Equal("content2", updated.Content);
        }

        [Fact]
        public async Task DeleteNote_ShouldRemoveNote()
        {
            using var db = DbFactory.CreateDb();

            var user = new User { Username = "bob", PasswordHash = "x" };
            db.Users.Add(user);

            var note = new Note { Title = "title", Content = "content", LastUpdatedByUserId = user.Id };
            db.Notes.Add(note);

            await db.SaveChangesAsync(TestContext.Current.CancellationToken);

            var repo = new NoteRepository(db);
            var service = new NoteService(repo);

            await service.DeleteAsync(note.Id);

            Assert.Empty(db.Notes);
        }
    }
}
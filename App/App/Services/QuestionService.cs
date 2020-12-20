using App.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public class QuestionService
    {
        private readonly IMongoCollection<Question> _questions;

        // ** Connects to the Atlas cluster as admin:admin123 and the LongCovidApp database
        public QuestionService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _questions = database.GetCollection<Question>("Questions");
        }

        // ** CRUD operations **

        // Creates a question
        public Question Create(Question question)
        {
            _questions.InsertOne(question);
            return question;
        }
        
        // Reads all questions into a list
        public IList<Question> Read() =>
            _questions.Find(q => true).ToList();

        // Finds a particular question
        public Question Find(int id) =>
            _questions.Find(q => q.Id == id).SingleOrDefault();

        // Updates a given question (Doesn't change Id)
        public void Update(Question question) =>
            _questions.ReplaceOne(q => q.Id == question.Id, question);

        // Deletes a particular question
        public void Delete(int id) =>
            _questions.DeleteOne(q => q.Id == id);
    }
}

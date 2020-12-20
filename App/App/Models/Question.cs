using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace App.Models
{
    public class Question
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; } // Question Id makes it easy to map all answers to a given question
        public string Content { get; set; } // The actual question itself
        public string Answer { get; set; } // The answer to the question (might need to be casted to an int for example if it's a 1 - 10 check box)
    }
}

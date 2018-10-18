using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Repositories;

namespace Repository.Tests
{   
    [TestFixture]
    public class RepositoryTests
    {
        private IRepository<Entity> _repository;
        private List<Entity> _collection;

        [SetUp]
        public void BeforeEach()
        {
            
            var persons = new List<Entity>();
            persons.Add(new Person(){Id = 2});
            persons.Add(new Person(){Id = 1});
            _collection = persons;
            _repository = new Repositories.Repository(persons);
        }

        [Test]
        public void Get()
        {
            //Arrange
            var person = new Person(){Id = 1};

            //Act
            var result = _repository.Get(person);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<Person>());
        }

        [Test]
        public void Add()
        {
            //Arrange
            var newPerson = new Person(){Id = 3};

            //Act
            _repository.Add(newPerson);
            var result = _repository.Get(newPerson);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<Person>());
            Assert.That(result.Id, Is.EqualTo(3));

        }

        [Test]
        public void SortById()
        {

            //Arrange
            //Act
            var result = _repository.SortById(_collection);
            var id = result.First().Id;
            //Assert
            Assert.That(id, Is.EqualTo(1));

        }

    }
}

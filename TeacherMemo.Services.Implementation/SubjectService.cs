using AutoMapper;
using System.Collections.Generic;
using TeacherMemo.Domain;
using TeacherMemo.Persistence.Abstact;
using TeacherMemo.Persistence.Abstact.Entities;
using TeacherMemo.Services.Abstract;
using TeacherMemo.Shared.Exceptions;

namespace TeacherMemo.Services.Implementation
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _repository;

        public SubjectService(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public void Add(Subject item)
        {
            var entity = Mapper.Map<SubjectEntity>(item);
            _repository.Add(entity);
            _repository.SaveChanges();
        }

        public void DeleteByName(string subjectName)
        {
            if (_repository.GetByName(subjectName) == null)
            {
                throw new NotFoundException($"Entity with name {subjectName} not found.");
            }
            _repository.DeleteByName(subjectName);
            _repository.SaveChanges();
        }

        public IEnumerable<Subject> GetAll()
        {
            var entities = _repository.GetAll();
            return Mapper.Map<IEnumerable<Subject>>(entities);
        }

        public Subject GetByName(string subjectName)
        {
            var entity = _repository.GetByName(subjectName);
            return Mapper.Map<Subject>(entity);
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using TeacherMemo.Domain;
using TeacherMemo.Persistence.Abstact;
using TeacherMemo.Persistence.Abstact.Entities;
using TeacherMemo.Services.Abstract;
using TeacherMemo.Shared.Exceptions;

namespace TeacherMemo.Services.Implementation
{
    public class MemoService : IMemoService
    {
        private readonly IMemoRepository _repository;
        private readonly IUserService _userService;

        public MemoService(IMemoRepository repository, IUserService userService)
        {
            _repository = repository;
            _userService = userService;
        }

        public Memo Add(Memo item)
        {
            var entity = Mapper.Map<MemoEntity>(item);
            entity.UserId = _userService.CurrentUserId;
            _repository.Add(entity);
            _repository.SaveChanges();
            return Mapper.Map<Memo>(entity);
        }

        public Memo Update(Memo item)
        {
            if (_repository.Get(item.Id) == null)
            {
                throw new NotFoundException($"Entity with id {item.Id} not found.");
            }

            var entity = Mapper.Map<MemoEntity>(item);
            entity.UserId = _userService.CurrentUserId;
            _repository.Update(entity);
            _repository.SaveChanges();
            return Mapper.Map<Memo>(entity);
        }

        public void Delete(int id)
        {
            if (_repository.Get(id) == null)
            {
                throw new NotFoundException($"Entity with id {id} not found.");
            }
            _repository.Delete(id);
            _repository.SaveChanges();
        }

        public Memo Get(int id)
        {
            var entity = _repository.Get(id);
            if (entity == null || entity.UserId != _userService.CurrentUserId)
            {
                return null;
            }
            return Mapper.Map<Memo>(entity);
        }

        public IEnumerable<Memo> GetAll()
        {
            var entities = _repository.GetAll();
            return Mapper.Map<IEnumerable<Memo>>(entities.Where(x => x.UserId == _userService.CurrentUserId));
        }

        public IEnumerable<Memo> GetAllForAllTeachers()
        {
            var entities = _repository.GetAll();
            return Mapper.Map<IEnumerable<Memo>>(entities);
        }

        public IEnumerable<Memo> FindInRangeByLecturesHours(int from, int to)
        {
            if (from < 0 || to < 0)
            {
                throw new ArgumentException($"From/To parameter should be >= 0");
            }
            if (from > to)
            {
                throw new ArgumentException($"Parameter 'From' should be <= 'To'");
            }

            var entities = _repository.Find(x => x.LectureHours >= from && x.LectureHours <= to).OrderBy(x => x.LectureHours);
            return Mapper.Map<IEnumerable<Memo>>(entities.Where(x => x.UserId == _userService.CurrentUserId));
        }
    }
}

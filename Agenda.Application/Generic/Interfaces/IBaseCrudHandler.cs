using Agenda.Application.Generic.Dtos;
using Agenda.Domain.Entities;

namespace Agenda.Application.Generic.Interfaces
{
    public interface IBaseCrudHandler<TDto, TEntity> where TDto : BaseDto where TEntity : BaseEntity
    {
        Task<IQueryable<TEntity>> Query();
        Task<TDto> GetById(int id);
        Task<TDto> Create(TDto dto);
        Task<TDto> Update(TDto dto);
        Task<TDto> Update(int id, TDto dto);
        Task<bool> Delete(int id);
    }
}

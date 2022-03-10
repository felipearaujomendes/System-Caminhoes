using caminhoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace caminhoes.Application.Queries
{
    public interface ICaminhaoQueries
    {
        Task<IEnumerable<Caminhao>> ObterTodos();

        Task<Caminhao> ObterPorId(Guid id);

    }
}

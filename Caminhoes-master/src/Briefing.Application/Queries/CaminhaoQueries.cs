using AutoMapper;
using caminhoes.Domain.Entities;
using caminhoes.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace caminhoes.Application.Queries
{
    public class caminhaoQueries : ICaminhaoQueries
    {
        private readonly IMapper _mapper;
        private readonly ICaminhaoRepository _caminhaoRepository;
        
        public caminhaoQueries(IMapper mapper, ICaminhaoRepository caminhaoRepository)
        {
            _mapper = mapper;
            _caminhaoRepository = caminhaoRepository;
        }

        public async Task<Caminhao> ObterPorId(Guid id)
        {
          return  await  _caminhaoRepository.ObterPorId(id);
        }

        public async Task<IEnumerable<Caminhao>> ObterTodos()
        {
            return await _caminhaoRepository.ObterTodos();
        }
    }
}

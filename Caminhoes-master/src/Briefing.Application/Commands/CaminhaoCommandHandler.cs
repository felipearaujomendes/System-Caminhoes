using AutoMapper;
using caminhoes.Domain.Entities;
using caminhoes.Domain.Interfaces.Repositories;
using caminhoes.Domain.Messages;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace caminhoes.Application.Commands
{
    public class CaminhaoCommandHandler : IRequestHandler<CaminhaoCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly ICaminhaoRepository _perguntaRepository;

        public CaminhaoCommandHandler(IMapper mapper, ICaminhaoRepository perguntaRepository)
        {
            _mapper = mapper;
            _perguntaRepository = perguntaRepository;
        }

        public async Task<bool> Handle(CaminhaoCommand message, CancellationToken cancellationToken)
        {
            try
            {
                if (!ValidarComando(message)) return false;
                
                var entity = _mapper.Map<Caminhao>(message);
                await _perguntaRepository.Adicionar(entity);
                message.AggregateRoot = entity.Id;
                return await _perguntaRepository.UnitOfWork.Commit();
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ValidarComando(Command message)
        {
            if (message.EhValido()) return true;
            return false;
        }
    }
}

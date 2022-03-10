using caminhoes.Domain.Entities;
using caminhoes.Domain.Interfaces.Repositories;
using caminhoes.Infrastructure.Data.Contexts;

namespace caminhoes.Infrastructure.Data.Repositories
{
    public class CaminhaoRepository: Repository<Caminhao>, ICaminhaoRepository
    {
        public CaminhaoRepository(QuizContext context):base(context)
        {

        }
    }
}

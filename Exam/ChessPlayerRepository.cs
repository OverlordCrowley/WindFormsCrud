using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class ChessPlayerRepository
    {
        private readonly postgresContext _db;

        public ChessPlayerRepository(postgresContext db)
        {
            _db = db;
        }

        public void Create(ChessPlayer entity)
        {
            _db.ChessPlayers.Add(entity);
            _db.SaveChanges();
        }

        public IQueryable<ChessPlayer> GetAll()
        {
            return _db.ChessPlayers;
        }

        public void Delete(ChessPlayer entity)
        {
            _db.ChessPlayers.Remove(entity);
            _db.SaveChanges();
        }

        public void Update(ChessPlayer entity)
        {
            _db.ChessPlayers.Update(entity);
            _db.SaveChanges();
        }
    }
}

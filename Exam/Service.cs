using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public static class Service
    {
        public static List<ChessPlayer> Update(DataGridView dataGridView, postgresContext postgresContext)
        {
            dataGridView.DataSource = null;
            return postgresContext.ChessPlayers.ToList();
        }
    }
}

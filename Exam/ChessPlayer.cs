using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam
{
    public partial class ChessPlayer
    {
        [Key]
        public int Идентификатор { get; set; }
        public string? Страна { get; set; }
        public string? Фамилия { get; set; }
        public string? Звание { get; set; }
        public int? Рейтинг { get; set; }
    }
}

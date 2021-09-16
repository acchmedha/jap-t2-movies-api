﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Models
{
    public class MoviesWithMostSoldTicketsReport
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string ScreeningName { get; set; }
        public int SoldTickets { get; set; }
    }
}

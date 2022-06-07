using Players_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Players_web.ViewModels
{
    public class PlayersVM
    {
        public Player[] Players { get; set; }
        public int PageCount { get; set; }
    }
}
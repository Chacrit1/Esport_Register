using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport
{
    internal class Player
    {
        [DisplayName("ชื่อจริง")]
        public string Name { get; set; }
        [DisplayName("ชื่อในเกม")]
        public string Username { get; set; }

        public Player(string name, string username)
        {
            this.Name = name;
            this.Username = username;
        }
    }
}

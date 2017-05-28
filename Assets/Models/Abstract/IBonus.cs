using System.Net.Security;
using UnityEngine;

namespace Models.Abstract {

    public interface IBonus {
        BasicMachine Machine { get; set; }
        
        void Boost();
            
    }

}

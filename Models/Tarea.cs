using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendTasks.Models
{
    public class Tarea
    {
        public int idTask { get; set; }
        public string description { get; set; }
        public string stateTask { get; set; }
        public string priority { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFinal { get; set; }
        public int idPeople { get; set; }
        public string notes { get; set; }

        public string getNamePerson(List<Persona> persona) {

            foreach (var item in persona)
            {
                if(item.idPeople==idPeople){
                    return item.namePeople;
                }
            }
            return "";
        }
        public string modalViewTask()
        {
            return "v"+idTask;
        }
        public string modalEditTask()
        {
            return "e" + idTask;
        }


    }
}

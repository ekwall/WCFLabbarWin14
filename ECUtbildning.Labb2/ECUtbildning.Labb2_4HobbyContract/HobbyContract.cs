using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ECUtbildning.Labb2_4HobbyContract
{
    [ServiceContract(Namespace = "ECUtbildning.HobbyContract", Name ="IHobbyContract")]
    public interface IHobby
    {
        [OperationContract(Name = "CapitalizeLetters")]
        string CapitalizeLettersHaha([MessageParameter(Name="input")]string stringinput);
    }

    public class HobbyService : IHobby
    {
        public string CapitalizeLettersHaha([MessageParameter(Name = "input")] string stringinput)
        {
            return stringinput.ToUpper();
        }
    }
}

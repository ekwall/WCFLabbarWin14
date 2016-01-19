using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;



namespace ECUtbildning.SelfService
{
    [ServiceContract(Namespace = "ECUtbildning.SelfService")]
    public interface ICalculateBMI
    {
        [OperationContract]
        double CalcBMI(double weight, double height);
    }
    public class CalculateBMI : ICalculateBMI
    {
        public double CalcBMI(double weight, double height)
        {
            return (weight / (height * height));
           

        }
    }
}

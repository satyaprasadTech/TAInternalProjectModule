using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TAServiceLibrary
{
    [ServiceContract]
    interface IClassifiedService
    {
        [OperationContract]
        void GetAdd();
        [OperationContract]
        void GetUserDetails();
        [OperationContract]
        void GetLoginDetails();
    }
}

using AnimeProtos;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeServer.Services {
    public class CustomerService : Customer.CustomerBase {

        public override Task<CustomerModel> GetCustomerInfo(CustomerInfoLookup request, ServerCallContext context) {
            CustomerModel res = new CustomerModel();
            res.FirstName = "fucker";

            return Task.FromResult(res);
        }

        public override async Task GetNewCustomers(VoidRequest request, IServerStreamWriter<CustomerModel> responseStream, ServerCallContext context) {
            //return base.GetNewCustomers(request, responseStream, context);
            List<CustomerModel> customers = new List<CustomerModel>() {
            new CustomerModel { FirstName = "Jhone"},
            new CustomerModel { FirstName = "Fuck"},
            new CustomerModel { FirstName = "Shit"},
            };

            foreach (var c in customers) {
               await responseStream.WriteAsync(c);
            }
        }

        public override Task<CustomersModel> GetAllCustomers(VoidRequest request, ServerCallContext context) {
            //return base.GetAllCustomers(request, context);
            List<CustomerModel> customers = new List<CustomerModel>();

            CustomersModel res = new CustomersModel();
            return Task.FromResult(res);
        }
    }
}

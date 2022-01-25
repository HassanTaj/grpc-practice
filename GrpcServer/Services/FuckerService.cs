using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;

namespace GrpcServer.Services {
    public class FuckerService : Fucker.FuckerBase {

        public override async Task<FuckABitchReply> FuckABitch(FuckABitchReq request, ServerCallContext context) {
            return await Task.FromResult(new FuckABitchReply {
                Message = $"{request.Name} Fucked hard."
            });
        }

        //public async Task<FuckABitchReply> FuckABitchAsync(FuckABitchReq request, ServerCallContext context) {
        //    return await Task.FromResult(new FuckABitchReply {
        //        Message = $"{request.Name} Fucked hard."
        //    });
        //}
    }
}

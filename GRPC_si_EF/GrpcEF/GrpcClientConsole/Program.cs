﻿using Grpc.Net.Client;
using System;

namespace GrpcClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");


        }
    }
}

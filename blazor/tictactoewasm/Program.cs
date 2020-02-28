﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using tictactoeweb.Shared.DesignPatterns;

namespace tictactoewasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<TicTacToeGame>();
            builder.RootComponents.Add<App>("app");
            await builder.Build().RunAsync();
        }
    }
}

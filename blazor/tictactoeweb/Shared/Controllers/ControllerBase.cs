
using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;
// using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Components;
using tictactoeweb.Shared.DesignPatterns;
using tictactoeweb.Shared.Models;

namespace tictactoeweb.Shared.Controllers
{
    public class ControllerBase : ComponentBase
    {
        protected void log(object msg){
            AppBase.log(msg);
        }
        // protected async Task<bool> loading_gif(){
        //     return await AppBase.loading_gif();
        // }
        // protected async Task<bool> init(){
        //     return await Building.Init();
        // }
    }
}


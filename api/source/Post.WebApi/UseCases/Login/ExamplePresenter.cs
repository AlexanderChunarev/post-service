using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Example;

namespace Post.WebApi.UseCases.Login 
{
    public sealed class ExamplePresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            throw new System.NotImplementedException();
        }

        public void Standard()
        {
            throw new System.NotImplementedException();
        }
    }
}
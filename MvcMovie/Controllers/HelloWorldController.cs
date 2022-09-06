//namespace organize class library
namespace MvcMovie.Controllers{
public class HelloWorldController:Controller{
    //http endpoint
public string Index(){
    return "this is my default action";
}

//http endpoint
public string Welcome(){
    return "This is welcome action method";
}
}
}

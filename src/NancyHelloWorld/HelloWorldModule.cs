using Nancy;

namespace NancyHelloWorld
{
    public class HelloWorldModule : NancyModule
    {
        public HelloWorldModule()
        {
            // 以下のアドレスでアクセスされた場合
            // http://localhost:9001/helloworld
            // http://localhost:9001/helloworld/
            Get["/"] = parameter => {
                return "Hello world!!";
            };

            // 以下のアドレスでアクセスされた場合
            // http://localhost:9001/helloworld/{name}
            Get["/{name}"] = parameter => {
                return string.Format("Hi {0}, Hello world!!", parameter.name);
            };
        }
    }
}

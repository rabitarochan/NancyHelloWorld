using System;
using Nancy.Hosting.Self;

namespace NancyHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // サーバのインスタンスを作成
            var host = new NancyHost(
                new Uri("http://localhost:9001/helloworld/")
            );

            // サーバ開始
            host.Start();
            
            // 入力を待つ
            Console.ReadLine();

            // サーバ定義
            host.Stop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Core;
using InversionOfControl.Entities;

namespace InversionOfControl
{
    public class Program
    {
        private static IContainer Container { get; set; }
        private static void Main(string[] args)
        {
            /*try
            {
                Console.WriteLine("Ahh");
                throw new Exception("new Ahtung");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }*/

            var a = new A();
            a = new B(3);
            a.Method();
            /*var builder = new ContainerBuilder();

            builder.RegisterType<GameManager>().As<IGameManager>();

            List<Parameter> enemyConstructorParamaters = new List<Parameter>(3) 
            { 
                new NamedParameter("health", 12), 
                new NamedParameter("power", 10),
                new NamedParameter("NickName", "Evil")
            };

            builder.RegisterType<Enemy>().As<IEnemy>().WithParameters(enemyConstructorParamaters);

            List<Parameter> playerConstructorParameters = new List<Parameter>(3)
            {
                new NamedParameter("health", 7),
                new NamedParameter("power", 6),
                new NamedParameter("NickName", "Vlad")
            };
            builder.RegisterType<Player>().As<IPlayer>().WithParameters(playerConstructorParameters); 
            Container = builder.Build();

            StartApp();*/
        }

        public class A
        {
            static A()
            {
                Console.WriteLine("Static A");
            }

            public A()
            {
                Console.WriteLine("A . ");
            }

            public A(int m)
            {
                Console.WriteLine("Am");
            }

            public virtual void Method()
            {
                Console.WriteLine("Method A.");
            }
        }

        interface IDog
        {
            void Walk();
            void Run();
            void Sit();
        }

        public class B : A
        {
            static B()
            {
                Console.WriteLine("Static B");
            }

            public B()
            {
                Console.WriteLine("B.");
            }

            public B(int m)
            {
                Console.WriteLine("Bm");
            }

            public override void Method()
            {
                Console.WriteLine("Method B.");
                base.Method();
            }
        }
        private static void StartApp()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var gameManager = scope.Resolve<IGameManager>();
                gameManager.ComparePlayerAndEnemyHealths();
            }
        }
    }
}
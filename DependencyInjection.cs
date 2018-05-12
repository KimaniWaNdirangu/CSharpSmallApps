using Microsoft.Practices.Unity;
using System; using System.Collections.Generic;
using System.Linq; using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DependencyInjection
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            IUnityContainer container = new UnityContainer(); 
            container.RegisterType<Login>(); 
            container.RegisterType<IAuthentication, FacebookAuthentication>("Facebook"); 
            container.RegisterType<IAuthentication, GoogleAuthentication>("Google"); 
            var authenticationSystem = container.Resolve<IAuthentication>( ConfigurationManager.AppSettings["LoginAuthenticationProvider"] ); 
            var login = container.Resolve<Login>(new DependencyOverride(typeof(IAuthentication), authenticationSystem)); 
            login.Authenticate("John", "pwd"); 
            Console.ReadLine();
        } 
    } 
    
    public interface IAuthentication 
    { 
        bool Login(string userName, string password);
    } 
             
    public class FacebookAuthentication : IAuthentication 
    { 
        public bool Login(string userName, string password) 
        { 
            return true; 
        } 
    }
    
    public class GoogleAuthentication : IAuthentication 
    { 
        public bool Login(string userName, string password) 
        { 
            return true; 
        }
    } 

    public class Login 
    { 
        private IAuthentication _authentication;

        public Login(IAuthentication authentication) 
        { 
            this._authentication = authentication; 
        }

        public bool Authenticate(string userName, string password) 
        { 
            return _authentication.Login(userName, password); 
        } 
    } 
} 


/*
<?xml version="1.0" encoding="utf-8" ?> 
 <configuration> 
  <appSettings> 
   <add key="LoginAuthenticationProvider" value="Facebook"/> 
  </appSettings>
  <startup> 
   <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6" /> 
  </startup>
</configuration>
 */

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject2
{
    public class Tests
    {

        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            //Esta parte nos llevara a la parte del Crud
            //Los Thread.Sleep los utilice para darle un tiempo definido a cada accion
            Console.WriteLine("Setup");
            driver.Navigate().GoToUrl("file:///C:/Users/Lenovo/Desktop/New%20folder%20(5)/Crud/crud.html");
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);

            //Esta parte precionara la parte para anadir un nuevo usuario
            IWebElement input = driver.FindElement(By.Id("btnNuevo"));
            input.Click();

            Thread.Sleep(1000);

            //Esta parte llenara la parte del nombre

            IWebElement Nombre = driver.FindElement(By.Id("nombre"));
            Nombre.SendKeys("Francisco");

            Thread.Sleep(3000);

            // Esta llenara la parte del apellido

            IWebElement Apellido = driver.FindElement(By.Id("apellido"));
            Apellido.SendKeys("Concepcion");

            Thread.Sleep(4000);

            //Esta llenara la parte del correo

            IWebElement Correo = driver.FindElement(By.Id("correo"));
            Correo.SendKeys("Edwinmartinezgimenez@gmail.com");

            Thread.Sleep(5000);

            // Esta llenara la parte del telefono 

            IWebElement Telefono = driver.FindElement(By.Id("telefono"));
            Telefono.SendKeys("8096832688");

            //Esta accion es para quue precione el boton guardar y guarde la informacion introducida

            IWebElement btn_Guardar = driver.FindElement(By.Id("btnGuardar"));
            btn_Guardar.Click();

            Thread.Sleep(3000);

            







        }

        
        

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
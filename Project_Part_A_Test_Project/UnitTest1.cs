using OOP_Project_A;

namespace Project_Part_A_Test_Project
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CarConstructor_ShouldInitializeProperties()
        {
            // Arrange
            int id = 1;
            string model = "TestModel";
            int year = 2023;
            CarType type = CarType.Sedan;

            // Act
            Car car = new Car(id, model, year, type);

            // Assert
            Assert.AreEqual(id, car.Id);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(year, car.Year);
            Assert.AreEqual(type, car.Type);
        }

        [TestMethod]
        public void CarManufacturerConstructor_ShouldInitializeProperties()
        {
            // Arrange
            string name = "TestManufacturer";
            int founded = 2000;

            // Act
            CarManufacturer manufacturer = new CarManufacturer(name, founded);

            // Assert
            Assert.AreEqual(name, manufacturer.Name);
            Assert.AreEqual(founded, manufacturer.Founded);
            Assert.IsNotNull(manufacturer.Cars);
        }

        [TestMethod]
        public void RaceConstructor_ShouldInitializeProperties()
        {
            // Arrange
            Car car1 = new Car(1, "Car1", 2020, CarType.Sedan);
            Car car2 = new Car(2, "Car2", 2021, CarType.Coupe);

            // Act
            Race race = new Race(car1, car2);

            // Assert
            Assert.AreEqual(car1, race.Car1);
            Assert.AreEqual(car2, race.Car2);
        }

        [TestMethod]
        public void DriverConstructor_ShouldInitializeProperties()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            int age = 30;
            string nationality = "USA";
            int salary = 50000;

            // Act
            Driver driver = new Driver(firstName, lastName, age, nationality, salary);

            // Assert
            Assert.AreEqual(firstName, driver.FirstName);
            Assert.AreEqual(lastName, driver.LastName);
            Assert.AreEqual(age, driver.Age);
            Assert.AreEqual(nationality, driver.Nationality);
            Assert.AreEqual(salary, driver.Salary);


        }
    }
    [TestClass]
    public class RaceTests
    {
        [TestMethod]
        public void PrintToDisplay_ShouldPrintRaceDetails()
        {
            // Arrange
            Car car1 = new Car(1, "Car1", 2020, CarType.Sedan);
            Car car2 = new Car(2, "Car2", 2021, CarType.Coupe);
            Race race = new Race(car1, car2);

            // Act
            string result = TestHelper.CaptureConsoleOutput(() => race.PrintToDisplay());

            // Assert
            StringAssert.Contains("Race Details:", result);
            StringAssert.Contains("Car1", result);
            StringAssert.Contains("Car2", result);
        }
    }

    public static class TestHelper
    {
        public static string CaptureConsoleOutput(Action action)
        {
            var originalOut = Console.Out;
            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);

                action();

                return consoleOutput.ToString();
            }
        }
    }
}
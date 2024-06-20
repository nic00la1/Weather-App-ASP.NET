# Weather App - Asp.Net + Razor 🌦️
![home](https://github.com/nic00la1/Weather-App-ASP.NET/assets/99048749/ed6c4da9-b896-4751-be02-1ab4d0f57c20)
![city-detail](https://github.com/nic00la1/Weather-App-ASP.NET/assets/99048749/5a777782-9be2-4467-9686-8cea964aee77)

## Overview 📄
WeatherApp is an ASP.NET Core Web Application designed to display weather details for selected cities 🌍.
It showcases the use of ASP.NET MVC architecture, Razor views, and attribute routing to create 
a responsive and user-friendly interface 🖥️. The application provides weather details for three hardcoded cities,
allowing users to view the temperature 🌡️ and other relevant information either for all cities at once or
for a selected city based on its unique code.

## Features 😎

•	Display Weather Details: Users can view weather details for London, New York, and Paris, including temperature in Celcius 🌡️, date 📅, and time ⏰.

•	City Selection: By navigating to a specific URL, users can view weather details for a selected city using its unique city code 🏙️.

•	Error Handling: The application gracefully handles invalid city codes by displaying an appropriate error message 🚫 instead of throwing an exception.

•	Responsive UI: Utilizes CSS styles and Razor view engine for a consistent and modern user interface. The UI displays weather details in boxes with background colors that vary based on the temperature range 🎨.

## Model 📊
The application uses a model class named CityWeather with the following properties:

•	string CityUniqueCode 🔑

•	string CityName 🏙️

•	DateTime DateAndTime 📅⏰

•	int Temperature 🌡️

## Controllers 🎮
The application contains a controller with attribute routing to handle requests:

•	HomeController: Manages the application's home page and weather details page. It initializes hardcoded data for the cities and returns views with model data.

## Endpoints 🔗

•	GET /: Displays weather details for all cities.

•	GET /weather/{cityCode}: Displays weather details for the selected city based on the cityCode route parameter.

## Views 👀
The application uses strongly-typed views to display weather details. It includes a view for displaying all cities' weather and another view for showing details of a selected city. A local function within the view determines the appropriate CSS class for background color based on the temperature.

## Error Handling 🚫
For invalid city codes, the application returns a view with a user-friendly error message, ensuring a smooth user experience even in case of incorrect input.

## Styling 💅
The application's UI is styled using a provided CSS file, which includes definitions for background colors based on temperature ranges. The UI design is modern and consistent, with the option for further enhancements.

## Conclusion 🏁
WeatherApp demonstrates the capabilities of ASP.NET Core for building web applications with dynamic content. It leverages MVC architecture, Razor views, and attribute routing to deliver a responsive and user-friendly weather information platform.

using System;
using System.Windows;
using System.Windows.Media.Imaging;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            const int DAY = 0;
            const int FIRST_DAY = 1;
            const int SECOND_DAY = 2;
            const int THIRD_DAY = 3;
            const int FOURTH_DAY = 4;
            const int FIFTH_DAY = 5;
            const int SIXTH_DAY = 6;

            WeatherInformation weather;

            try
            {
                weather = new AppService().DeserializationJson(city.Text);
            }
            catch
            {
                MessageBox.Show("Такого города не существует!");
                return;
            }

            string uri = "http:" + weather.Forecast.ForecastDay[DAY].Day.Condition.Icon;
            image.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[FIRST_DAY].Day.Condition.Icon;
            imageFirst.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[SECOND_DAY].Day.Condition.Icon;
            imageSecond.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[THIRD_DAY].Day.Condition.Icon;
            imageThird.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[FOURTH_DAY].Day.Condition.Icon;
            imageFourth.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[FIFTH_DAY].Day.Condition.Icon;
            imageFifth.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[SIXTH_DAY].Day.Condition.Icon;
            imageSixth.Source = new BitmapImage(new Uri(uri));


            temperatureInCelsius.Text = Convert.ToInt32(weather.Forecast.ForecastDay[DAY].Day.MaximumTemperatureInCelsius).ToString() 
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusFirst.Text = Convert.ToInt32(weather.Forecast.ForecastDay[FIRST_DAY].Day.MaximumTemperatureInCelsius).ToString() 
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[FIRST_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusSecond.Text = Convert.ToInt32(weather.Forecast.ForecastDay[SECOND_DAY].Day.MaximumTemperatureInCelsius).ToString()
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[SECOND_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusThird.Text = Convert.ToInt32(weather.Forecast.ForecastDay[THIRD_DAY].Day.MaximumTemperatureInCelsius).ToString() 
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[THIRD_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusFourth.Text = Convert.ToInt32(weather.Forecast.ForecastDay[FOURTH_DAY].Day.MaximumTemperatureInCelsius).ToString() 
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[FOURTH_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusFifth.Text = Convert.ToInt32(weather.Forecast.ForecastDay[FIFTH_DAY].Day.MaximumTemperatureInCelsius).ToString() 
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[FIFTH_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusSixth.Text = Convert.ToInt32(weather.Forecast.ForecastDay[SIXTH_DAY].Day.MaximumTemperatureInCelsius).ToString() 
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[SIXTH_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            date.Text = weather.Forecast.ForecastDay[DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[DAY].Date.Value.ToShortDateString();
            dateFirst.Text = weather.Forecast.ForecastDay[FIRST_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[FIRST_DAY].Date.Value.ToShortDateString();
            dateSecond.Text = weather.Forecast.ForecastDay[SECOND_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[SECOND_DAY].Date.Value.ToShortDateString();
            dateThird.Text = weather.Forecast.ForecastDay[THIRD_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[THIRD_DAY].Date.Value.ToShortDateString();
            dateFourth.Text = weather.Forecast.ForecastDay[FOURTH_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[FOURTH_DAY].Date.Value.ToShortDateString();
            dateFifth.Text = weather.Forecast.ForecastDay[FIFTH_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[FIFTH_DAY].Date.Value.ToShortDateString();
            dateSixth.Text = weather.Forecast.ForecastDay[SIXTH_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[SIXTH_DAY].Date.Value.ToShortDateString();

            humidity.Text = "Влажность - " + weather.Forecast.ForecastDay[DAY].Day.AverageHumidity.ToString() + "%";
            humidityFirst.Text = "Влажность - " + weather.Forecast.ForecastDay[FIRST_DAY].Day.AverageHumidity.ToString() + "%";
            humiditySecond.Text = "Влажность - " + weather.Forecast.ForecastDay[SECOND_DAY].Day.AverageHumidity.ToString() + "%";
            humidityThird.Text = "Влажность - " + weather.Forecast.ForecastDay[THIRD_DAY].Day.AverageHumidity.ToString() + "%";
            humidityFourth.Text = "Влажность - " + weather.Forecast.ForecastDay[FOURTH_DAY].Day.AverageHumidity.ToString() + "%";
            humidityFifth.Text = "Влажность - " + weather.Forecast.ForecastDay[FIFTH_DAY].Day.AverageHumidity.ToString() + "%";
            humiditySixth.Text = "Влажность - " + weather.Forecast.ForecastDay[SIXTH_DAY].Day.AverageHumidity.ToString() + "%";

            windSpeed.Text = "Скорость ветра - " + Convert.ToInt32(weather.Forecast.ForecastDay[DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedFirst.Text = "Скорость ветра - " + Convert.ToInt32(weather.Forecast.ForecastDay[FIRST_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedSecond.Text = "Скорость ветра - " + Convert.ToInt32(weather.Forecast.ForecastDay[SECOND_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedThird.Text = "Скорость ветра - " + Convert.ToInt32(weather.Forecast.ForecastDay[THIRD_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedFourth.Text = "Скорость ветра - " + Convert.ToInt32(weather.Forecast.ForecastDay[FOURTH_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedFifth.Text = "Скорость ветра - " + Convert.ToInt32(weather.Forecast.ForecastDay[FIFTH_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedSixth.Text = "Скорость ветра - " + Convert.ToInt32(weather.Forecast.ForecastDay[SIXTH_DAY].Day.WindSpeed).ToString() + "км/ч";
        }
    }
}

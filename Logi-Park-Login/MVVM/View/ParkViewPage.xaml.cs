﻿using LogiPark.MVVM.Model;
using LogiPark.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogiPark.MVVM.View
{
    /// <summary>
    /// Interaction logic for ParkViewPage.xaml
    /// </summary>
    public partial class ParkViewPage : UserControl
    {
        private string _parkName;
        private ProgramClient _client;
        public ParkViewPage()
        {
        }

        public ParkViewPage(string parkName)
        {
            InitializeComponent();
            this._client = new ProgramClient();

            _parkName = parkName;   // Now we have the park name -> can request park data from server (data + reviews)
            ParkNameTextBlock.Text = _parkName;

            // 1. Request Park Reviews
            _client.SendParkReviewsRequest(_parkName);

            // 1. Receive Park Reviews
            DisplayParkReviews();

            // 2. Request Park Data
            _client.SendOneParkDataRequest(_parkName);

            // 2. Receive Park Data
            DisplayParkData();

            // 3. Request Park Image
            _client.SendOneParkImageRequest(_parkName);

            // 3. Request Park Image
            DisplayParkImage(_parkName);
        }

        private void DisplayParkReviews()
        {
            // All the matching reviews are saved in a list because there could be more than one reviews per park
            List<ParkReviewManager.ParkReviewData> reviews = _client.ReceiveParkReviewsResponse();

            // In case there is any reviews stack panel already exist then we clear it first before starting to create reviews card
            ReviewsStackPanel.Children.Clear(); 

            // Iterate through each review and build a review card
            foreach (ParkReviewManager.ParkReviewData review in reviews)
            {
                // Main container for each review
                Border reviewCard = new Border
                {
                    Padding = new Thickness(10),
                    Background = new SolidColorBrush(ColorConverter.ConvertFromString("#F0F0F0") as Color? ?? Colors.LightGray),
                    CornerRadius = new CornerRadius(5),
                    Height = 126,
                    Margin = new Thickness(5)
                };

                // Instantiate a StackPannel for the review content
                StackPanel reviewContent = new StackPanel();

                // Instantiate a StackPannel for the user info with properties inside
                StackPanel userInfoPanel = new StackPanel 
                { 
                    Orientation = Orientation.Horizontal, 
                    Height = 36 
                };
                
                // Instantiate an Ellipse shape to represent a user icon with properties inside
                Ellipse userIcon = new Ellipse
                {
                    Width = 30,
                    Height = 29,
                    Fill = new SolidColorBrush(Colors.LightBlue),
                    Margin = new Thickness(0, 0, 10, 0)
                };

                // Instantiate StackPannel for the username location with properties inside
                StackPanel userNameLocationPanel = new StackPanel 
                { 
                    Width = 120 
                };

                // Add contents and extra properties to user name location panel 
                userNameLocationPanel.Children.Add(new TextBlock 
                { 
                    Text = review.UserName, 
                    FontWeight = FontWeights.Bold 
                });

                // Add more contents and properties to user name location pannel
                userNameLocationPanel.Children.Add(new TextBlock 
                { 
                    Text = "Waterloo, ON", 
                    FontStyle = FontStyles.Italic 
                }); 

                // Add user icon object into user info panel
                userInfoPanel.Children.Add(userIcon);

                // Add username location panel object into user info panel
                userInfoPanel.Children.Add(userNameLocationPanel);

                // Instantiate Stack Panel for rating date panel with properties inside
                StackPanel ratingDatePanel = new StackPanel 
                { 
                    Orientation = Orientation.Horizontal, 
                    Margin = new Thickness(0, 10, 0, 0) 
                };

                // Add more contents and properties into the rating date panel 
                ratingDatePanel.Children.Add(new TextBlock 
                { 
                    Text = $"{review.Rating.ToString("0")} / 5 stars", 
                    FontWeight = FontWeights.Bold, 
                    Foreground = new SolidColorBrush(Colors.OrangeRed) 
                });

                // Add more contents and properties into the rating date panel
                ratingDatePanel.Children.Add(new TextBlock 
                { 
                    Text = review.DateOfPosting.ToString("MMM dd, yyyy"), 
                    Margin = new Thickness(10, 0, 0, 0) 
                });

                // Instantiate TextBlock for review text with contents and properties inside
                TextBlock reviewTextBlock = new TextBlock
                {
                    Text = review.Review,
                    TextWrapping = TextWrapping.Wrap,
                    Width = 250,
                    Margin = new Thickness(0, 10, 0, 0)
                };

                // Building the card with different children components (userinfo + rating date + review text) => One review card
                reviewContent.Children.Add(userInfoPanel);
                reviewContent.Children.Add(ratingDatePanel);
                reviewContent.Children.Add(reviewTextBlock);

                reviewCard.Child = reviewContent;

                // Finally, Add the card to the StackPanel
                ReviewsStackPanel.Children.Add(reviewCard);
            }
        }
    

        private void DisplayParkData()
        {
            this.Dispatcher.Invoke(() =>
            {
                ParkDataManager.ParkData parkData = _client.ReceiveOneParkDataResponse();
                ParkNameTextBlock.Text = parkData.parkName;

                ParkRatingTextBlock.Text = $"Rating: {parkData.parkReview} stars";
                ParkReviewsCountTextBlock.Text = $"{parkData.numberOfReviews} reviews";
                ParkAddressTextBlock.Text = parkData.parkAddress;

                // Dynamically generate star ratings based on the rounded-down rating
                double roundedRating = Math.Floor(parkData.parkReview);
                List<BitmapImage> stars = new List<BitmapImage>();
                for (int i = 0; i < roundedRating; i++)
                {
                    stars.Add(new BitmapImage(new Uri("/Assets/Icons/star-rating-icon.png", UriKind.Relative)));
                }
                StarRatingControl.ItemsSource = stars;

            });
        }

        private void DisplayParkImage(string parkName)
        {
            this.Dispatcher.Invoke(() =>
            {
                BitmapImage parkImage = _client.ReceiveOneParkImageResponse();

                SetParkImage(parkImage);
            });
        }

        public void SetParkImage(BitmapImage image)
        {
            ParkImage.Source = image;
        }

        private void ReviewButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"park name: { _parkName}");
        }
    }
}

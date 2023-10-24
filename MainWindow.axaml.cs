using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MySql.Data.MySqlClient;
using TokioHotel.Entities;

namespace TokioHotel;

public partial class MainWindow : Window
{
    private string _con = "server=10.10.1.24;database=pro1_11;user=user_01;password=user01pro";
    private List<Rent> _rents;
    private MySqlConnection _connection;
    public MainWindow()
    {
        InitializeComponent();
        ShowTable();
    }

    public void ShowTable()
    {
        string sql = "select Rent_ID, Reservation, Initials, Price, Payment, Hotel_Room from pro1_11.Rent" +
                     " join pro1_11.Guest G on Rent.Guest = G.Guest_ID";
        _rents = new List<Rent>();
        _connection = new MySqlConnection(_con);
        _connection.Open();
        MySqlCommand command = new MySqlCommand(sql, _connection);
        MySqlDataReader reader = command.ExecuteReader();
        while (reader.Read() && reader.HasRows)
        {
            var curRent = new Rent()
            {
                Rent_ID = reader.GetInt32("Rent_ID"),
                Reservation = reader.GetInt32("Reservation"),
                Guest = reader.GetString("Initials"),
                Price = reader.GetInt32("Price"),
                Payment = reader.GetInt32("Payment"),
                Hotel_Room = reader.GetInt32("Hotel_Room")
            };
            _rents.Add(curRent);
        }
        _connection.Close();
        RentDataGrid.ItemsSource = _rents;

    }
}

using EnumExercisesFinal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercisesFinal.Entities
{
    internal class Order
    {
        public DateTime Moment {  get; set; }
        public Client Client { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, Client client, OrderStatus status)
        {
            Moment = moment;
            Client = client;
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Item)
            {
                sum += item.subTotal();
            }

            return sum;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Moment ");
            sb.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine();
            sb.Append("Order Status: ");
            sb.Append(Status);
            sb.AppendLine();
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append($" ({Client.BirhDate})" );
            sb.Append(" - ");
            sb.Append(Client.Email);
            sb.AppendLine();
            sb.AppendLine("Order Items: ");
            foreach(OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Price final: " + total().ToString("F2", CultureInfo.InvariantCulture)) ;
            return sb.ToString();



        }

    }
}

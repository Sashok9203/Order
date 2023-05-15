using Order;

namespace Order
{
    public partial class Form1 : Form
    {
        private Product? drink = null;
        private Product? dessert = null;
        private Product? dish = null;
        private readonly Product[] drinks;
        private readonly Product[] desserts;
        private readonly Product[] dishes;
        public Form1()
        {
            int ind;
            InitializeComponent();

            drinks = new Product[]
            {
                new("Пепсі", 15.5),
                new("Кока - Кола", 16.2),
                new("Сік виноградний", 18.70),
                new("Мінеральна вода", 10),
                new("Молочний коктейль", 25.60),
            };

            desserts = new Product[]
              {
               new("Шоколадний торт", 45),
               new("Чизкейк", 56.2),
               new("Тірамісу", 60.2),
               new("Фруктовий салат", 70),
               new("Морозиво", 35)
              };

            dishes = new Product[]
            {
               new("Борщ", 90.45),
               new("Суп-пюре", 70),
               new("Грибна юшка", 72.34),
               new("Мінестроне", 80.1),
               new("Солянка", 80)
            };

            foreach (var gBox in Controls.OfType<GroupBox>())
            {
                ind = 0;
                foreach (var item in gBox.Controls.OfType<RadioButton>())
                {
                    Product[]? tmpArr = null;
                    switch (gBox.Name)
                    {
                        case "drinkGroupBox": tmpArr = drinks; break;
                        case "dishGroupBox": tmpArr = dishes; break;
                        case "dessertGroupBox": tmpArr = desserts; break;
                        default: continue;
                    }
                    item.Text = tmpArr?[ind]?.ToString() ?? "Продукт відсутній";
                    item.Checked = false;
                    ind++;
                }
            }

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            UserOrder tmp = new(drink, dish, dessert);
            MessageBox.Show($"             Замовлення № {UserOrder.OrderNumber}\n\nДата : {tmp.OrderDate}\n" +
                $"Напій : {tmp.Drink?.Name}\n" +
                $"Десерт : {tmp.Dessert?.Name}\n" +
                $"Основна страва : {tmp.Dish?.Name}\n" +
                $"Сумарна вартість : {tmp.OrderPrice} гр.", $"Звмовлення № {UserOrder.OrderNumber}") ;


            orderText.AppendText(tmp.ToString());
            orderText.AppendText(Environment.NewLine);

            drink = null;
            dessert = null;
            dish = null;
            foreach (var gBox in Controls.OfType<GroupBox>())
            {
                var rbtmp = gBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
                if (rbtmp != null) rbtmp.Checked = false;
            }


        }

        private void IsOrderComplete() => orderButton.Enabled = (drink != null && dessert != null && dish != null);

        private void Exit(object sender, EventArgs e) => Close();

        private void drinkSelect(object sender, EventArgs e)
        {
            int index = drinkGroupBox.Controls.OfType<RadioButton>().TakeWhile(n => n.Checked == false).Count();
            if (index != drinks.Length) drink = drinks[index];
            IsOrderComplete();
        }

        private void dessertSelect(object sender, EventArgs e)
        {
            int index = dessertGroupBox.Controls.OfType<RadioButton>().TakeWhile(n => n.Checked == false).Count();
            if (index != desserts.Length) dessert = desserts[index];
            IsOrderComplete();
        }

        private void dishSelect(object sender, EventArgs e)
        {
            int index = dishGroupBox.Controls.OfType<RadioButton>().TakeWhile(n => n.Checked == false).Count();
            if (index != dishes.Length) dish = dishes[index];
            IsOrderComplete();
        }


    }
}
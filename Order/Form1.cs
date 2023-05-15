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
                new("����", 15.5),
                new("���� - ����", 16.2),
                new("ѳ� �����������", 18.70),
                new("̳�������� ����", 10),
                new("�������� ��������", 25.60),
            };

            desserts = new Product[]
              {
               new("���������� ����", 45),
               new("�������", 56.2),
               new("ҳ�����", 60.2),
               new("��������� �����", 70),
               new("��������", 35)
              };

            dishes = new Product[]
            {
               new("����", 90.45),
               new("���-����", 70),
               new("������ ����", 72.34),
               new("̳��������", 80.1),
               new("�������", 80)
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
                    item.Text = tmpArr?[ind]?.ToString() ?? "������� �������";
                    item.Checked = false;
                    ind++;
                }
            }

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            UserOrder tmp = new(drink, dish, dessert);
            MessageBox.Show($"             ���������� � {UserOrder.OrderNumber}\n\n���� : {tmp.OrderDate}\n" +
                $"���� : {tmp.Drink?.Name}\n" +
                $"������ : {tmp.Dessert?.Name}\n" +
                $"������� ������ : {tmp.Dish?.Name}\n" +
                $"������� ������� : {tmp.OrderPrice} ��.", $"���������� � {UserOrder.OrderNumber}") ;


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
using OOAP_Lab1.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum ProductType
{
    Motherboard,
    Processor,
    HardDrive
}

namespace OOAP_Lab1
{
    public partial class ProdSystemForm : Form
    {
        public List<Product> products;
        public Product currentProduct;
        UC_Create uc_create;
        
        public ProductType productType;
        public ProdSystemForm()
        {
            InitializeComponent();

            products = new List<Product>();
        }

        private void addUserControl (UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void CreateProdClick(object sender, EventArgs e)
        {
            uc_create = new UC_Create(this);
            addUserControl(uc_create);

            if (panel_Button.Height == 191)
            {
                panel_Button.Height = 41;
            }
            else
            {
                panel_Button.Height = 191;
                panel_Button.BringToFront();
            }
        }

        private void addProdInputs(UserControl uc) 
        {
            panel_Button.Height = 41;
            Panel panel_prod = uc.Controls.Find("product_panel", true).FirstOrDefault() as Panel;

            switch (productType) 
            {
                case ProductType.Motherboard:
                    currentProduct = new Motherboard();

                    Label label_socket_type = new Label()
                    {
                        Text = "Тип сокета",
                        Location = new Point(30, 50),
                        TabIndex = 10,
                        AutoSize = true
                    };
                    TextBox textbox_socket_type = new TextBox()
                    {
                        Location = new Point(180, 50),
                        TabIndex = 10,
                        Width = 90,
                        Name = "textBox_socket_type",
                        Text = "default"
                    };

                    Label label_num_of_proc = new Label()
                    {
                        Text = "Количество процессоров",
                        Location = new Point(30, 85),
                        TabIndex = 10,
                        AutoSize = true
                    };
                    NumericUpDown textbox_num_of_proc = new NumericUpDown()
                    {
                        Location = new Point(180, 85),
                        TabIndex = 10,
                        Width = 90,
                        Name = "textBox_num_of_proc",
                    };

                    Label label_ram_type = new Label()
                    {
                        Text = "Тип оперативной памяти",
                        Location = new Point(30, 120),
                        TabIndex = 10,
                        AutoSize = true
                    };
                    TextBox textbox_ram_type = new TextBox()
                    {
                        Location = new Point(180, 120),
                        TabIndex = 10,
                        Width = 90,
                        Name = "textBox_ram_type",
                        Text = "default"
                    };

                    Label label_system_bus_frec = new Label()
                    {
                        Text = "Частота системной шины",
                        Location = new Point(30, 155),
                        TabIndex = 10,
                        AutoSize = true
                    };
                    TextBox textbox_system_bus_frec = new TextBox()
                    {
                        Location = new Point(180, 155),
                        TabIndex = 10,
                        Width = 90,
                        Name = "textBox_system_bus_frec",
                        Text = "50,5"
                    };

                    panel_prod.Controls.Add(label_socket_type);
                    panel_prod.Controls.Add(textbox_socket_type);
                    panel_prod.Controls.Add(label_num_of_proc);
                    panel_prod.Controls.Add(textbox_num_of_proc);
                    panel_prod.Controls.Add(label_ram_type);
                    panel_prod.Controls.Add(textbox_ram_type);
                    panel_prod.Controls.Add(label_system_bus_frec);
                    panel_prod.Controls.Add(textbox_system_bus_frec);

                    break;
                case ProductType.Processor:
                    currentProduct = new Processor();

                    Label label_socket_type_ = new Label()
                    {
                        Text = "Тип сокета",
                        Location = new Point(30, 50),
                        TabIndex = 10,
                        AutoSize = true
                    };
                    TextBox textbox_socket_type_ = new TextBox()
                    {
                        Location = new Point(180, 50),
                        TabIndex = 10,
                        Width = 90,
                        Name = "textBox_socket_type",
                        Text = "default"
                    };

                    Label label_num_of_cores = new Label()
                    {
                        Text = "Количество ядер",
                        Location = new Point(30, 85),
                        TabIndex = 10,
                        AutoSize = true
                    };
                    NumericUpDown textbox_num_of_cores = new NumericUpDown()
                    {
                        Location = new Point(180, 85),
                        TabIndex = 10,
                        Width = 90,
                        Name = "textBox_num_of_cores"
                    };

                    Label label_clock_speed = new Label()
                    {
                        Text = "Тактовая частота",
                        Location = new Point(30, 120),
                        TabIndex = 10,
                        AutoSize = true
                    };
                    TextBox textbox_clock_speed = new TextBox()
                    {
                        Location = new Point(180, 120),
                        TabIndex = 10,
                        Width = 90,
                        Name = "textBox_clock_speed",
                        Text = "50,5"
                    };

                    Label label_tech_process = new Label()
                    {
                        Text = "Техпроцесс",
                        Location = new Point(30, 155),
                        TabIndex = 10,
                        AutoSize = true
                    };
                    TextBox textbox_tech_process = new TextBox()
                    {
                        Location = new Point(180, 155),
                        TabIndex = 10,
                        Width = 90,
                        Name = "textBox_tech_process",
                        Text = "50,5"
                    };

                    panel_prod.Controls.Add(label_socket_type_);
                    panel_prod.Controls.Add(textbox_socket_type_);
                    panel_prod.Controls.Add(label_num_of_cores);
                    panel_prod.Controls.Add(textbox_num_of_cores);
                    panel_prod.Controls.Add(label_clock_speed);
                    panel_prod.Controls.Add(textbox_clock_speed);
                    panel_prod.Controls.Add(label_tech_process);
                    panel_prod.Controls.Add(textbox_tech_process);

                    break;
                case ProductType.HardDrive:
                    currentProduct = new HardDrive();

                    Label label_volume = new Label()
                    {
                        Text = "Объем",
                        Location = new Point(50, 50),
                        TabIndex = 10
                    };
                    TextBox textbox_volume = new TextBox()
                    {
                        Location = new Point(180, 50),
                        TabIndex = 10,
                        Name = "textBox_volume",
                        Text = "50,5"
                    };

                    Label label_rpm = new Label()
                    {
                        Text = "Скорость вращения",
                        Location = new Point(50, 85),
                        TabIndex = 10
                    };
                    TextBox textbox_rpm = new TextBox()
                    {
                        Location = new Point(180, 85),
                        TabIndex = 10,
                        Name = "textBox_rpm",
                        Text = "50,5"
                    };

                    Label label_type_interface = new Label()
                    {
                        Text = "Тип интерфейса",
                        Location = new Point(50, 120),
                        TabIndex = 10
                    };
                    TextBox textbox_interface = new TextBox()
                    {
                        Location = new Point(180, 120),
                        TabIndex = 10,
                        Name = "textBox_type_interface",
                        Text = "default"
                    };

                    panel_prod.Controls.Add(label_volume);
                    panel_prod.Controls.Add(textbox_volume);
                    panel_prod.Controls.Add(label_rpm);
                    panel_prod.Controls.Add(textbox_rpm);
                    panel_prod.Controls.Add(label_type_interface);
                    panel_prod.Controls.Add(textbox_interface);

                    break;
            }
        }

        
        private void createMotherboard(object sender, EventArgs e)
        {
            productType = ProductType.Motherboard;
            addProdInputs(uc_create);
        }

        private void createProcessor(object sender, EventArgs e)
        {
            productType = ProductType.Processor;
            addProdInputs(uc_create);
        }

        private void createHardDrive(object sender, EventArgs e)
        {
            productType = ProductType.HardDrive;
            addProdInputs(uc_create);
        }

        private void ShowProdClick(object sender, EventArgs e)
        {
            UC_Show uc = new UC_Show(this);
            addUserControl(uc);
        }

        private void ProdSystemForm_Load(object sender, EventArgs e)
        {
            panel_Button.Height = 41;
        }
    }
}

public abstract class Product
{
    public int index { get; set; }
    public string name { get; set; }
    public double cost { get; set; }

    public abstract void saveProdInputs(UserControl uc);
    public abstract string showInfo();
    public abstract string getStringKey();
}

class Motherboard : Product
{
    public string socket_type { get; set; }
    public int num_of_proc { get; set; }
    public string ram_type { get; set; }
    public double system_bus_frec { get; set; }
    public override string showInfo()
    {
        string productInfo = $"Номер товара {index}\r\nТип товара: Материнская плата\r\n" +
            $"Наименование: {name}\r\nСтоимость: {cost}\r\n" +
            $"Тип сокета: {socket_type}\r\nКол-во процессоров: {num_of_proc}\r\n" +
            $"Тип оперативной памяти: {ram_type}\r\nЧастота системной шины: {system_bus_frec}";
        return productInfo;
    }
    public override void saveProdInputs(UserControl uc)
    {
        TextBox textbox_socket_type = uc.Controls.Find("textBox_socket_type", true).FirstOrDefault() as TextBox;
        NumericUpDown textbox_num_of_proc = uc.Controls.Find("textBox_num_of_proc", true).FirstOrDefault() as NumericUpDown;
        TextBox textbox_ram_type = uc.Controls.Find("textBox_ram_type", true).FirstOrDefault() as TextBox;
        TextBox textbox_system_bus_frec = uc.Controls.Find("textBox_system_bus_frec", true).FirstOrDefault() as TextBox;

        socket_type = textbox_socket_type.Text;
        num_of_proc = Convert.ToInt32(textbox_num_of_proc.Value);
        ram_type = textbox_ram_type.Text;
        system_bus_frec = Convert.ToDouble(textbox_system_bus_frec.Text);
    }
    public override string getStringKey() => "Материнская плата";
}

class Processor : Product
{
    public string socket_type { get; set; }
    public int num_of_cores { get; set; }
    public double clock_speed { get; set; }
    public double tech_process { get; set; }
    public override string showInfo()
    {
        string productInfo = $"Номер товара {index}\r\nТип товара: Процессор\r\n" +
            $"Наименование: {name}\r\nСтоимость: {cost}\r\n" +
            $"Тип сокета: {socket_type}\r\nКол-во ядер: {num_of_cores}\r\n" +
            $"Тактовая частота: {clock_speed}\r\nТехпроцесс: {tech_process}";
        return productInfo;
    }
    public override void saveProdInputs(UserControl uc)
    {
        TextBox textbox_socket_type = uc.Controls.Find("textBox_socket_type", true).FirstOrDefault() as TextBox;
        NumericUpDown textbox_num_of_cores = uc.Controls.Find("textBox_num_of_cores", true).FirstOrDefault() as NumericUpDown;
        TextBox textbox_clock_speed = uc.Controls.Find("textBox_clock_speed", true).FirstOrDefault() as TextBox;
        TextBox textbox_tech_process = uc.Controls.Find("textBox_tech_process", true).FirstOrDefault() as TextBox;

        socket_type = textbox_socket_type.Text;
        num_of_cores = Convert.ToInt32(textbox_num_of_cores.Value);
        clock_speed = Convert.ToDouble(textbox_clock_speed.Text);
        tech_process = Convert.ToDouble(textbox_tech_process.Text);
    }
    public override string getStringKey() => "Процессор";
}

class HardDrive : Product
{
    public double volume { get; set; }
    public double rpm { get; set; }
    public string type_interface { get; set; }
    public override string showInfo()
    {
        string productInfo = $"Номер товара {index}\r\nТип товара: Процессор\r\n" +
            $"Наименование: {name}\r\nСтоимость: {cost}\r\n" +
            $"Объем: {volume}\r\nСкорость вращения: {rpm}\r\n" +
            $"Тип интерфейса: {type_interface}";
        return productInfo;
    }

    public override void saveProdInputs(UserControl uc)
    {
        TextBox textbox_volume = uc.Controls.Find("textBox_volume", true).FirstOrDefault() as TextBox;
        TextBox textbox_rpm = uc.Controls.Find("textBox_rpm", true).FirstOrDefault() as TextBox;
        TextBox textbox_type_interface = uc.Controls.Find("textBox_type_interface", true).FirstOrDefault() as TextBox;

        volume = Convert.ToDouble(textbox_volume.Text);
        rpm = Convert.ToDouble(textbox_rpm.Text);
        type_interface = textbox_type_interface.Text;
    }
    public override string getStringKey() => "Жесткий диск";
}


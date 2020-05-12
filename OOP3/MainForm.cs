using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP3
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            
        }

        public List<Employee> employees = new List<Employee>();

        public void RefreshListBox()
        {
            employeesListView.Clear();
            foreach (Employee employee in employees)
            {
                var listItem = new ListViewItem();
                listItem.Text = employee.Name;
                employeesListView.Items.Add(listItem);
            }
            employeesListView.Enabled = true;
        }

        private void factoryWorkerButton_Click(object sender, EventArgs e)
        {
            try
            {
                employees.Add(new FactoryWorker(float.Parse(salaryTB.Text), idTB.Text, int.Parse(rankCB.Text), int.Parse(machineNumberTB.Text)));
                RefreshListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Заполните поля правильно!");
            } 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                employees.Add(new OfiiceEmployee(float.Parse(salaryTB.Text), idTB.Text, departmentCB.Text, positionTB.Text));
                RefreshListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните поля правильно!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                employees.Add(new Scientist(float.Parse(salaryTB.Text), idTB.Text, scienseDegreeCB.Text, researchAreaTB.Text));
                RefreshListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните поля правильно!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                employees.Add(new Security(float.Parse(salaryTB.Text), idTB.Text, int.Parse(serviseWeaponIDTB.Text), int.Parse(toleranceLevelCB.Text)));
                RefreshListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните поля правильно!");
            }

        }
            private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                employees.Add(new StorageEmployee(float.Parse(salaryTB.Text), idTB.Text, int.Parse(storageNumberTB.Text), storageTypeCB.Text));
                RefreshListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните поля правильно!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                employees.Add(new Сourier(float.Parse(salaryTB.Text), idTB.Text, autoTB.Text, courierTypeCB.Text));
                RefreshListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните поля правильно!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)   //SERIALIZING
        {
            JSONSerializer serializer = new JSONSerializer();   
            serializer.Serialize(employees);
            
            RefreshListBox();
        }

        private void ClearControls()
        {
            idTB.Clear();
            salaryTB.Clear();
            rankCB.Text = "";
            machineNumberTB.Clear();
            departmentCB.Text = "";
            positionTB.Clear();
            scienseDegreeCB.Text = "";
            researchAreaTB.Clear();
            toleranceLevelCB.Text = "";
            serviseWeaponIDTB.Clear();
            storageTypeCB.Text = "";
            storageNumberTB.Clear();
            courierTypeCB.Text = "";
            autoTB.Clear();
            employeesListView.Enabled = true;
        }
        
        private void employeesListView_SelectedIndexChanged(object sender, EventArgs e)
        { 
            infoTB.Clear();
            ClearControls();
            infoTB.Text = employees[employeesListView.SelectedIndices[0]].Name + Environment.NewLine;
            infoTB.Text += employees[employeesListView.SelectedIndices[0]].salary.ToString()+ " рублей" + Environment.NewLine;
            idTB.Text = employees[employeesListView.SelectedIndices[0]].Name;
            salaryTB.Text = employees[employeesListView.SelectedIndices[0]].salary.ToString();

            if (employees[employeesListView.SelectedIndices[0]] is FactoryWorker)
            {
                FactoryWorker factoryWorker = (FactoryWorker)employees[employeesListView.SelectedIndices[0]];
                infoTB.Text += factoryWorker.machineNumber.ToString() + " номер станка" + Environment.NewLine;
                infoTB.Text += factoryWorker.rank.ToString() + " разряд" + Environment.NewLine;
                rankCB.Text = factoryWorker.rank.ToString();
                machineNumberTB.Text = factoryWorker.machineNumber.ToString();

            }

            if (employees[employeesListView.SelectedIndices[0]] is OfiiceEmployee)
            {
                OfiiceEmployee ofiiceEmployee = (OfiiceEmployee)employees[employeesListView.SelectedIndices[0]];
                infoTB.Text += ofiiceEmployee.departmentName + Environment.NewLine;
                infoTB.Text += ofiiceEmployee.position + Environment.NewLine;
                departmentCB.Text = ofiiceEmployee.departmentName;
                positionTB.Text = ofiiceEmployee.position;
            }

            if (employees[employeesListView.SelectedIndices[0]] is Scientist)
            {
                Scientist scientist = (Scientist)employees[employeesListView.SelectedIndices[0]];
                infoTB.Text += scientist.scienceDegree + Environment.NewLine;
                infoTB.Text += scientist.researchArea + Environment.NewLine;
                scienseDegreeCB.Text = scientist.scienceDegree;
                researchAreaTB.Text = scientist.researchArea;
            }

            if (employees[employeesListView.SelectedIndices[0]] is Security)   
            {
                Security security = (Security)employees[employeesListView.SelectedIndices[0]];
                infoTB.Text += security.serviceWeaponID.ToString() + " номер служебного оружия" + Environment.NewLine;
                infoTB.Text += security.toleranceLevel.ToString() + " уровень допуска" + Environment.NewLine;
                toleranceLevelCB.Text = security.toleranceLevel.ToString();
                serviseWeaponIDTB.Text = security.serviceWeaponID.ToString();
            }
              
            if (employees[employeesListView.SelectedIndices[0]] is StorageEmployee)
            {
                StorageEmployee storageEmployee = (StorageEmployee)employees[employeesListView.SelectedIndices[0]];
                infoTB.Text += storageEmployee.storageNumber.ToString() + " номер склада" + Environment.NewLine;     
                infoTB.Text += storageEmployee.storageType + Environment.NewLine;                   
                storageTypeCB.Text = storageEmployee.storageType;                    
                storageNumberTB.Text = storageEmployee.storageNumber.ToString();
            }

            if (employees[employeesListView.SelectedIndices[0]] is Сourier)   
            {                    
                Сourier сourier = (Сourier)employees[employeesListView.SelectedIndices[0]];                   
                infoTB.Text += сourier.auto + " авто" + Environment.NewLine;                   
                infoTB.Text += сourier.corierType + Environment.NewLine;                   
                courierTypeCB.Text = сourier.corierType;                   
                autoTB.Text = сourier.auto;
            }
            employeesListView.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)   //DESERIALIZATION
        {
            infoTB.Clear();
            ClearControls();
            JSONSerializer serializer = new JSONSerializer();   
            employees = serializer.Deserialize();
            RefreshListBox();
        }

        private void button7_Click(object sender, EventArgs e)   //EDITING
        {
            try
            {
                infoTB.Clear();
                employees[employeesListView.SelectedIndices[0]].Name = idTB.Text;
                employees[employeesListView.SelectedIndices[0]].salary = float.Parse(salaryTB.Text);
                infoTB.Text = employees[employeesListView.SelectedIndices[0]].Name + Environment.NewLine;
                infoTB.Text += employees[employeesListView.SelectedIndices[0]].salary.ToString() + Environment.NewLine;
                employeesListView.Enabled = true;

                if (employees[employeesListView.SelectedIndices[0]] is FactoryWorker)
                {
                    FactoryWorker factoryWorker = (FactoryWorker)employees[employeesListView.SelectedIndices[0]];
                    factoryWorker.machineNumber = int.Parse(machineNumberTB.Text);
                    factoryWorker.rank = int.Parse(rankCB.Text);
                    infoTB.Text += factoryWorker.machineNumber.ToString() + Environment.NewLine;
                    infoTB.Text += factoryWorker.rank.ToString() + Environment.NewLine;
                }

                if (employees[employeesListView.SelectedIndices[0]] is OfiiceEmployee)
                {
                    OfiiceEmployee ofiiceEmployee = (OfiiceEmployee)employees[employeesListView.SelectedIndices[0]];
                    ofiiceEmployee.departmentName = departmentCB.Text;
                    ofiiceEmployee.position = positionTB.Text;
                    infoTB.Text += ofiiceEmployee.departmentName + Environment.NewLine;
                    infoTB.Text += ofiiceEmployee.position + Environment.NewLine;
                }

                if (employees[employeesListView.SelectedIndices[0]] is Scientist)
                {
                    Scientist scientist = (Scientist)employees[employeesListView.SelectedIndices[0]];
                    scientist.scienceDegree = scienseDegreeCB.Text;
                    scientist.researchArea = researchAreaTB.Text;
                    infoTB.Text += scientist.scienceDegree + Environment.NewLine;
                    infoTB.Text += scientist.researchArea + Environment.NewLine;
                }

                if (employees[employeesListView.SelectedIndices[0]] is Security)
                {
                    Security security = (Security)employees[employeesListView.SelectedIndices[0]];
                    security.serviceWeaponID = int.Parse(serviseWeaponIDTB.Text);
                    security.toleranceLevel = int.Parse(toleranceLevelCB.Text);
                    infoTB.Text += security.serviceWeaponID.ToString() + Environment.NewLine;
                    infoTB.Text += security.toleranceLevel.ToString() + Environment.NewLine;
                }

                if (employees[employeesListView.SelectedIndices[0]] is StorageEmployee)
                {
                    StorageEmployee storageEmployee = (StorageEmployee)employees[employeesListView.SelectedIndices[0]];
                    storageEmployee.storageNumber = int.Parse(storageNumberTB.Text);
                    storageEmployee.storageType = storageTypeCB.Text;
                    infoTB.Text += storageEmployee.storageNumber.ToString() + Environment.NewLine;
                    infoTB.Text += storageEmployee.storageType + Environment.NewLine;
                }

                if (employees[employeesListView.SelectedIndices[0]] is Сourier)
                {
                    Сourier сourier = (Сourier)employees[employeesListView.SelectedIndices[0]];
                    сourier.auto = autoTB.Text;
                    сourier.corierType = courierTypeCB.Text;
                    infoTB.Text += сourier.auto + Environment.NewLine;
                    infoTB.Text += сourier.corierType + Environment.NewLine;
                }
                RefreshListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите элемент");
                employeesListView.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)  //FIRING
        {
            try
            {
                infoTB.Clear();
                ClearControls();
                employees.RemoveAt(employeesListView.SelectedIndices[0]);
                RefreshListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите элемент");
                employeesListView.Enabled = true;
            }
        }


        private void MainForm_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

 
    }
}

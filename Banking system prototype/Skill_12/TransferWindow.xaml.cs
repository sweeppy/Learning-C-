﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Skill_12
{
    /// <summary>
    /// Логика взаимодействия для TransferWindow.xaml
    /// </summary>
    public partial class TransferWindow : Window
    {
        private MainWindow _mainWindow;
        public TransferWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            if (sender is Window w) w.Hide();
        }

        private void FinishBtn_Click(object sender, RoutedEventArgs e)
        {
            

            if (Program.CheckPhoneNumber(TboxPhoneNumberForTransfer.Text) && Program.CheckAmountOfMoney(TbForMoney.Text)
                && CbFromAccount.SelectedItem != null && CbToAccount.SelectedItem != null)
            {
                TransferLogic();
            }
            else//показ ошибок
            {
                ShowErrors();
            }
        }
        /// <summary>
        /// Показ ошибок
        /// </summary>
        private void ShowErrors()
        {
            string errors = "";
            List<string> errorList = new List<string>();

            if (!Program.CheckPhoneNumber(TboxPhoneNumberForTransfer.Text))
                errorList.Add("Пользователся с данным номером телефона не существует.");

            if (!Program.CheckAmountOfMoney(TbForMoney.Text))
                errorList.Add("Введена некорректная сумма денег.");

            if (CbFromAccount.SelectedItem == null)
                errorList.Add("Не выбран тип счета, с которого будет осуществлен перевод");

            if (CbToAccount.SelectedItem == null)
                errorList.Add("Не выбран тип счета, на который будет осуществлен перевод");

            foreach (var item in errorList)
            {
                errors += $"\n {item}";
            }
            System.Media.SystemSounds.Hand.Play();
            MessageBox.Show(errors);
        }
        /// <summary>
        /// Проверка всех данных для перевода и сам перевод
        /// </summary>
        private void TransferLogic()
        {
            bool success = false;

            Client from = _mainWindow.ListViewClients.SelectedItem as Client;//Клиент, от которого будет производиться перевод
            Client to = Program.FindClientByPhoneNumber(TboxPhoneNumberForTransfer.Text, MainWindow.clientList);
            //Клиент, к которому будет производиться перевод

            switch (CbFromAccount.SelectedIndex)
            {
                case 0:
                    if (from.DepositMoney != null)
                    //Проверка существования выбранного счета, с которого будет осуществлен перевод
                    {
                        switch (CbToAccount.SelectedIndex)
                        {

                            case 0:
                                if (to.DepositMoney != null)//Проверка существования выбранного счета, на который будет осуществлен перевод
                                {
                                    TransferProcessor transferProcessor = new TransferProcessor();
                                    transferProcessor.Transfer(from, to, Convert.ToDecimal(TbForMoney.Text), false, false);
                                    //Последние два параметра: false - депозитный, true - не депозитный
                                    success = true;
                                }
                                break;


                            case 1:
                                if (to.NonDepositMoney != null)//Проверка существования выбранного счета, на который будет осуществлен перевод
                                {
                                    TransferProcessor transferProcessor = new TransferProcessor();
                                    transferProcessor.Transfer(from, to, Convert.ToDecimal(TbForMoney.Text), false, true);
                                    //Последние два параметра: false - депозитный, true - не депозитный
                                    success = true;
                                }
                                break;
                        }

                        if (!success)
                        {
                            System.Media.SystemSounds.Hand.Play();
                            MessageBox.Show("У клиента, выбранного для перевода, нет данного типа счета.");
                        }
                        else this.Close();
                    }
                    else
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("У клиента, от которого хотите выполнить перевод, нет данного типа счета.");
                    }
                    break;

                case 1:
                    if (from.NonDepositMoney != null)
                    //Проверка существования выбранного счета, с которого будет осуществлен перевод
                    {
                        switch (CbToAccount.SelectedIndex)
                        {

                            case 0:
                                if (to.DepositMoney != null)//Проверка существования выбранного счета, на который будет осуществлен перевод
                                {
                                    TransferProcessor transferProcessor = new TransferProcessor();
                                    transferProcessor.Transfer(from, to, Convert.ToDecimal(TbForMoney.Text), true, false);
                                    //Последние два параметра: false - депозитный, true - не депозитный
                                    success = true;
                                }
                                break;


                            case 1:
                                if (to.NonDepositMoney != null)//Проверка существования выбранного счета, на который будет осуществлен перевод
                                {
                                    TransferProcessor transferProcessor = new TransferProcessor();
                                    transferProcessor.Transfer(from, to, Convert.ToDecimal(TbForMoney.Text), true, true);
                                    //Последние два параметра: false - депозитный, true - не депозитный
                                    success = true;
                                }
                                break;
                        }

                        if (!success)//перевод не выполнен
                        {
                            System.Media.SystemSounds.Hand.Play();
                            MessageBox.Show("У клиента, выбранного для перевода, нет данного типа счета.");
                        }
                        else//перевод выпонен
                        {
                            this.Close();
                            Program.SaveClientsToJson(MainWindow.clientList);
                        }

                    }
                    else
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("У клиента, от которого хотите выполнить перевод, нет данного типа счета.");
                    }
                    break;
            }
        }

        private void TboxPhoneNumberForTransfer_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TboxPhoneNumberForTransfer.Text == "Введите номер телфона клиента, на счет которого хотите осуществить перевод")
            {
                TboxPhoneNumberForTransfer.Clear();
            }
        }

        private void TbForMoney_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TbForMoney.Text == "Введите сумму перевода")
            {
                TbForMoney.Clear();
            }
        }
    }
}

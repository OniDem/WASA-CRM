using CommunityToolkit.Maui.Alerts;
using Core.Const;
using Core.Entity;
using System.Collections.ObjectModel;
using WASA_Mobile.Service;

namespace WASA_Mobile.Pages;

public partial class ReturnPage : ContentPage
{
    private readonly ObservableCollection<CancelReasonShowEntity> _cancelReasons = new()
    {
        new() { CancelReason = CancelReasonEnum.None, CancelReasonName = "�������"},
        new() { CancelReason = CancelReasonEnum.NonFit, CancelReasonName = "�� �������"},
        new() { CancelReason = CancelReasonEnum.Other, CancelReasonName = "������"},
        new() { CancelReason = CancelReasonEnum.Defect, CancelReasonName = "������"},
        new() { CancelReason = CancelReasonEnum.NonPayment, CancelReasonName = "�� ��������"},
    };
    private CancelReasonEnum cancelReason;
    public ReturnPage()
	{
		InitializeComponent();
        CancelReasonCarouselView.ItemsSource = _cancelReasons;
    }
    private void BackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new MainPage());
    }

    private void CancelReasonCarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        var item = CancelReasonCarouselView.CurrentItem as CancelReasonShowEntity;
        cancelReason = item!.CancelReason;
    }

    private async void ReturnButton_Clicked(object sender, EventArgs e)
    {
        var receipt = await ReceiptService.Cancel(new() { Id = Convert.ToInt32(ReceiptIdEntry.Text), CancelReason = cancelReason });
        if (receipt.Id > 0)
        {
            var toast = Toast.Make("������� ��������� �������");
            await toast.Show();
        }
        else
        {
            var toast = Toast.Make("��� �������� ��������� ������, ���������� �����");
            await toast.Show();
        }
    }
}
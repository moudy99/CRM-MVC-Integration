namespace DAL
{
    public static class FawryIntegration
    {
        public const string ReturnURLPath = "/WishListPayment/Completion";
        public const string ConfirmationPagePath = "/WishListPayment/Confirmation";
        public const string ReservationFeesReturnURLPath = "/WishListPayment/CompletionForReservation";
        public const string ReservationFeesConfirmationPagePath = "/WishListPayment/ConfirmationForReservation";
        public const string CommunityPaymentReturnURLPath = "/HandleResponse/HandleCommunityAppResponse";
        
    }
    public static class Organization
    {
        public const string Dev = "phd2";
        public const string Sandbox = "unq6d812e188bcded11aed0000d3a3a0";
        public const string Production = "unq5c79a6108bcded11aed0000d3a64d";
        public const int QueueLimit = 25;
    }
    public static class TimeZones
    {
        public const string EgyptTimezone = "Egypt Standard Time";
    }

    public static class PropertyUnit_Status
    {
        public const int Available = 153160000;
        public const int Booked = 550220004;
        public const int Reserved = 153160001;
        public const int Contracted = 550220003;
        public const int Blocked = 100000001;
        public const int FixedAssets = 550220006;
        public const int UnderMaintenance = 153160003;
        public const int Inactive = 550220001;
        public const int Active = 550220000;
        public const int Registered = 550220005;
        public const int Occupied = 153160002;
        public const int MoveIn = 550220002;
        public const int MoveOut = 858870000;
        public const int TempReserved = 550220007;

    }
    public static class PropertyUnit_BlockReason
    {
        public const int BlockedForRepricing = 100000001;
        public const int BlockedBySales = 100000000;
    }

    public static class PaymentTerm_Type
    {
        public const int Reservation = 550220000;
        public const int AgreementPayment = 550220005;
        public const int FullPayment = 550220002;
        public const int RemainingPayment = 550220003;
        public const int TransferPayment = 550220004;
        public const int Installment = 550220001;
    }

    public static class PaymentTerm_Calculation
    {
        public const int Percent = 550220000;
        public const int Amount = 550220001;
    }

    public static class OpportunityRequest_Type
    {
        public const int ReservationRequest = 550220009;
        public const int ExtendReservationRequest = 550220008;
        public const int DiscountChangeRequest = 550220011;
        public const int ClubChangeRequest = 550220012;
        public const int PaymentPlanChangeRequest = 550220004;
    }

    public static class OpportunityRequest_Status
    {
        public const int Initiated = 550220000;
        public const int InProgress = 550220001;
        public const int Approved = 550220002;
        public const int Cancelled = 550220003;
    }

    public static class Approval_Status
    {
        public const int New = 858870003;
        public const int Pending = 858870000;
        public const int Approved = 858870001;
        public const int Rejected = 858870002;
    }

    public static class Opportunity_Stage
    {
        public const int Develop = 1;
        public const int Propose = 2;
        public const int Reservation = 3;
        public const int SalesAgreement = 4;
        public const int TitleDeedTransfer = 5;
        public const int Handover = 6;
    }

    public static class Opportunity_StatusCode
    {
        public const int Open = 0;
        public const int Won = 1;
        public const int Lost = 2;
    }

    public static class Opportunity_StateCode
    {
        public const int InProgress = 1;
        public const int OnHold = 2;
        public const int Won = 3;
        public const int Canceled = 4;
        public const int OutSold = 5;
    }
    public static class PropertyAgreement_Status
    {
        public const int Active = 550220001;
        public const int Canceled = 550220003;
        public const int Approved = 550220004;
        public const int Upgrade = 881980001;
        public const int Downgrade = 881980002;
        public const int PendingforTransition = 550220002;
        public const int Signed = 550220005;
        public const int ChangeCustomer = 100000000;
        public const int ChangeUnitNo = 100000001;
        public const int NeedsUpdates = 100000002;
        public const int Reschedule = 100000003;
        public const int Draft = 550220000;
    }

    public static class Reservation_Type
    {
        public const int New = 550220000;
        public const int Change = 550220001;
    }
    public static class Reservation_StatusReason
    {
        public const int Active = 1;
        public const int Cancel = 550220000;
        public const int ChangeUnit = 550220001;
    }
    public static class LaunchCampaign_Status
    {
        public const int Draft = 550220000;
        public const int Approved = 550220001;
        public const int PreLaunch = 550220002;
        public const int Launched = 550220003;
        public const int Finished = 550220004;
        public const int Rejected = 550220005;
        public const int ModificationRequired = 550220006;
        public const int Submitted = 550220007;
    }
    public static class Wishlist_Status
    {
        public const int Pending = 550220000;
        public const int Confirmed = 550220001;
        public const int Fulfilled = 550220002;
        public const int Missed = 550220003;
        public const int Cancelled = 550220004;

    }
    public static class WishlistItem_Status
    {
        public const int Pending = 550220000;
        public const int Waitlisted = 550220003;
        public const int Guaranteed = 550220005;
        public const int Skipped = 550220006;
        public const int Booked = 550220001;
        public const int Reserved = 550220002;
        public const int Missed = 550220004;
        public const int QueueLimitExceeded = 550220007;
        public const int Cancelled = 550220008;
    }

    public static class PaymentTransaction_Status
    {
        public const int Pending = 550220000;
        public const int Initiated = 550220001;
        public const int Failed = 550220002;
        public const int Completed = 550220003;
    }
    public static class QueueTurn_Status
    {
        public const int Confirmed = 1;
        public const int NowServing = 550220003;
        public const int Fulfilled = 2;
        public const int Skipped = 550220000;
        public const int Postponed = 550220001;
        public const int Cancelled = 550220002;
    }
    public static class QueueTurn_Status_SMS_Content
    {
        public const string Confirmed = "The payment for your Expression of Interest (EOI) fees has been confirmed successfully.";
        public const string NowServing = "Your request is currently being processed.";
        public const string Fulfilled = "Congratulations.\nWe're pleased to inform you that you successfully secured a reservation. Your active participation is greatly appreciated.";
        public const string Skipped = "We regret to inform you that your turn for the launch has been skipped. \n \n Despite your call in turn, you were not present at the scheduled time, and as a result, we had to move on to the next customer.\n\n If you still wish to participate, please contact us to reschedule your turn.\r\n\r\nThank you for your understanding.";
        public const string Postponed = "We would like to inform you that your turn for the launch has been postponed.\n \n Although you called in your turn and were present, we understand that you need more time to make the reservation. \n \n Please let us know when you are ready to proceed, and we will be happy to assist you further.\r\n\r\nThank you for your patience and understanding.";
        public const string Cancelled = "We regret to inform you that your turn for the launch has been cancelled.\r\n\r\nIf you have any further inquiries or would like to reschedule, please get in touch with us.\r\n\r\nThank you for your understanding.";
    }

    public static class CommumicationActivity_Type
    {
        public const int SMS = 550220000;
    }
    public static class ErrorCode
    {
        public const int CampaignPreLanuchError = 5001;
        public const int UserWishlistsLimitError = 5002;
        public const int AccountWishlistsLimitError = 5003;
        public const int WishlistUnitsLimitError = 5004;
        public const int SameAccountUnitError = 5005;
    }
    public static class LaunchCampaign_Type
    {
        public const int Launch = 550220000;
        public const int Release = 550220001;
    }
    public static class PaymentTransaction_Type
    {
        public const int EOI = 550220000;
        public const int Reservation = 550220001;
    }

}

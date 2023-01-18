namespace Business.Constants
{
    // Constants = Sabit

    // Sabit olduğu için static
    // newlenmeye gerek yoktur
    public static class Messages
    {
        // Public - PascalCase
        public static string ProductAdded = "Ürün Eklendi";
        // Ürün ismi geçersiz
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";

        public static string CategoryLimitExceded = "kategori sayısı fazla";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered { get; internal set; }
        public static string UserNotFound { get; internal set; }
        public static string PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
    }
}

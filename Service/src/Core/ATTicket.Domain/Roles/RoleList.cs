using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTicket.Domain.Roles
{
    public sealed class RoleList
    {
        public static List<AppRole> GetStaticRoles()
        {
            List<AppRole> appRoles = new List<AppRole>
        {
        
            
            #region PRODUCT
            new AppRole(title: PRODUCT,code : PRODUCTCreateCode,name : PRODUCTCreateName),
            new AppRole(title: PRODUCT,code : PRODUCTUpdateCode,name : PRODUCTUpdateName),
            new AppRole(title: PRODUCT,code : PRODUCTRemoveCode,name : PRODUCTRemoveName),
            new AppRole(title: PRODUCT,code : PRODUCTReadCode,  name : PRODUCTReadName),
	        #endregion   
            
            #region CUSTOMER
            new AppRole(title: CUSTOMER,code : CUSTOMERCreateCode,name : CUSTOMERCreateName),
            new AppRole(title: CUSTOMER,code : CUSTOMERUpdateCode,name : CUSTOMERUpdateName),
            new AppRole(title: CUSTOMER,code : CUSTOMERRemoveCode,name : CUSTOMERRemoveName),
            new AppRole(title: CUSTOMER,code : CUSTOMERReadCode,  name : CUSTOMERReadName),
	        #endregion      

            #region DOCUMENTS
            new AppRole(title: DOCUMENTS,code : DOCUMENTSCreateCode,name : DOCUMENTSCreateName),
            new AppRole(title: DOCUMENTS,code : DOCUMENTSUpdateCode,name : DOCUMENTSUpdateName),
            new AppRole(title: DOCUMENTS,code : DOCUMENTSRemoveCode,name : DOCUMENTSRemoveName),
            new AppRole(title: DOCUMENTS,code : DOCUMENTSReadCode,  name : DOCUMENTSReadName),
	        #endregion

            #region BASKETSTATUS
            new AppRole(title: BASKETSTATUS,code : BASKETSTATUSCreateCode,name : BASKETSTATUSCreateName),
            new AppRole(title: BASKETSTATUS,code : BASKETSTATUSUpdateCode,name : BASKETSTATUSUpdateName),
            new AppRole(title: BASKETSTATUS,code : BASKETSTATUSRemoveCode,name : BASKETSTATUSRemoveName),
            new AppRole(title: BASKETSTATUS,code : BASKETSTATUSReadCode,  name : BASKETSTATUSReadName),
	        #endregion

            #region PRODUCTCOMPANIES
            new AppRole(title: PRODUCTCOMPANIES,code : PRODUCTCOMPANIESCreateCode,name : PRODUCTCOMPANIESCreateName),
            new AppRole(title: PRODUCTCOMPANIES,code : PRODUCTCOMPANIESUpdateCode,name : PRODUCTCOMPANIESUpdateName),
            new AppRole(title: PRODUCTCOMPANIES,code : PRODUCTCOMPANIESRemoveCode,name : PRODUCTCOMPANIESRemoveName),
            new AppRole(title: PRODUCTCOMPANIES,code : PRODUCTCOMPANIESReadCode,  name : PRODUCTCOMPANIESReadName),
	        #endregion
        };

            return appRoles;
        }

        public static List<MainRole> GetStaticMainRoles()
        {
            List<MainRole> mainRoles = new List<MainRole>
        {
            new MainRole(
                Guid.NewGuid().ToString(),
                "Admin",
                true),
            new MainRole(
                Guid.NewGuid().ToString(),
                "Yönetici",
                true),
            new MainRole(
                Guid.NewGuid().ToString(),
                "Kullanıcı",
                true),
        };
            return mainRoles;
        }

        #region RoleTitleNames
        //public static string UCAF = "Hesap Planı";

        public static string PRODUCT = "URUNLER";
        public static string CUSTOMER = "MUSTERILER";
        public static string DOCUMENTS = "DOKUMANLAR";
        public static string BASKETSTATUS = "SEPET DURUMU";
        public static string PRODUCTCOMPANIES = "URUN KAMPANYALARI";

        #endregion

        #region RoleCodeAndNames


        public static string PRODUCTCreateCode = "PRODUCT.CREATE";
        public static string PRODUCTCreateName = "URUN KAYIT";
        public static string PRODUCTUpdateCode = "PRODUCT.UPDATE";
        public static string PRODUCTUpdateName = "URUN GUNCELLE";
        public static string PRODUCTRemoveCode = "PRODUCT.REMOVE";
        public static string PRODUCTRemoveName = "URUN SIL";
        public static string PRODUCTReadCode = "PRODUCT.READ";
        public static string PRODUCTReadName = "URUN GORUNTULE";

        public static string CUSTOMERCreateCode = "CUSTOMER.CREATE";
        public static string CUSTOMERCreateName = "MUSTERI KAYIT";
        public static string CUSTOMERUpdateCode = "CUSTOMER.UPDATE";
        public static string CUSTOMERUpdateName = "MUSTERI GUNCELLE";
        public static string CUSTOMERRemoveCode = "CUSTOMER.REMOVE";
        public static string CUSTOMERRemoveName = "MUSTERI SIL";
        public static string CUSTOMERReadCode = "CUSTOMER.READ";
        public static string CUSTOMERReadName = "MUSTERI GORUNTULE";


        public static string DOCUMENTSCreateCode = "DOCUMENTS.CREATE";
        public static string DOCUMENTSCreateName = "DOKUMAN KAYIT";
        public static string DOCUMENTSUpdateCode = "DOCUMENTS.UPDATE";
        public static string DOCUMENTSUpdateName = "DOKUMAN GUNCELLE";
        public static string DOCUMENTSRemoveCode = "DOCUMENTS.REMOVE";
        public static string DOCUMENTSRemoveName = "DOKUMAN SIL";
        public static string DOCUMENTSReadCode = "DOCUMENTS.READ";
        public static string DOCUMENTSReadName = "DOKUMAN GORUNTULE";

        public static string BASKETSTATUSCreateCode = "BASKETSTATUS.CREATE";
        public static string BASKETSTATUSCreateName = "SEPET DURUM KAYIT";
        public static string BASKETSTATUSUpdateCode = "BASKETSTATUS.UPDATE";
        public static string BASKETSTATUSUpdateName = "SEPET DURUM GUNCELLE";
        public static string BASKETSTATUSRemoveCode = "BASKETSTATUS.REMOVE";
        public static string BASKETSTATUSRemoveName = "SEPET DURUM SIL";
        public static string BASKETSTATUSReadCode = "BASKETSTATUS.READ";
        public static string BASKETSTATUSReadName = "SEPET DURUM GORUNTULE";

        public static string PRODUCTCOMPANIESCreateCode = "PRODUCTCOMPANIES.CREATE";
        public static string PRODUCTCOMPANIESCreateName = "URUN KAMPANYA KAYIT";
        public static string PRODUCTCOMPANIESUpdateCode = "PRODUCTCOMPANIES.UPDATE";
        public static string PRODUCTCOMPANIESUpdateName = "URUN KAMPANYA GUNCELLE";
        public static string PRODUCTCOMPANIESRemoveCode = "PRODUCTCOMPANIES.REMOVE";
        public static string PRODUCTCOMPANIESRemoveName = "URUN KAMPANYA SIL";
        public static string PRODUCTCOMPANIESReadCode = "PRODUCTCOMPANIES.READ";
        public static string PRODUCTCOMPANIESReadName = "URUN KAMPANYA GORUNTULE";





        #endregion
    }
}

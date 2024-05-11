/*using DTO.EnumCore;

namespace DTO.Utils
{
    public class CalculateHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cTinh"></param>
        /// <param name="donViTinh"></param>
        /// <param name="giaTri">La tieu thu m3 hoac gia tri tien (Da dc tru m3 mien phi neu co)</param>
        /// <returns></returns>
        public static decimal GiaBVMT(CachTinhBVMT cTinh, decimal donViTinh, decimal giaTri)
        {
            //Tính theo phần trăm: tiền theo phần trăm
            if (cTinh == CachTinhBVMT.PhanTram)
            {
                return giaTri * (donViTinh / 100);
            }
            //Tính theo m3: số lượng m3 * tiền
            //Khong mien phi
            else if (cTinh == CachTinhBVMT.M3)
            {
                return donViTinh * giaTri;
            }
            //tính theo m3: co miễn phí thi chua tinh vi chua biet cach tinh
            return donViTinh * giaTri;
        }

        // public static decimal GiaDTDNC(CachTinhPhiDuyTri cTinh, decimal donViTinh, decimal giaTri)
        // {
        //     //Tính theo phần trăm: tiền theo phần trăm
        //     if (cTinh == CachTinhPhiDuyTri.MKhoi || cTinh == CachTinhPhiDuyTri.MKhoiHoaDon_KoSDNuoc)
        //     {
        //         return donViTinh * giaTri;
        //     }
        //     //Tính theo m3: số lượng m3 * tiền
        //     //Khong mien phi
        //     else if (cTinh == CachTinhPhiDuyTri.TienMKhoi_KoMienPhi || cTinh == CachTinhPhiDuyTri.TienHoaDon_KoSDNuo)
        //     {
        //         return giaTri * (donViTinh / 100);
        //     }
        //     //tính theo m3: co miễn phí thi chua tinh vi chua biet cach tinh
        //     return giaTri * (donViTinh / 100);
        // }

        public static decimal GiaVAT(decimal ChiPhi, decimal VAT)
        {
            return ChiPhi * (VAT);
        }
        public static decimal ChiPhiCoVAT(decimal ChiPhi, decimal VAT)
        {
            return ChiPhi + GiaVAT(ChiPhi, VAT);
        }
    }
}*/
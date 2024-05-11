namespace DTO.Constants
{
    public static class WebApiEndpoint
    {
        public const string AreaName = "api";

        public static class ThanhToan
        {
            private const string BaseEndpoint = "~/" + AreaName + "/thanh-toan";
            public const string FilterThanhToan = BaseEndpoint + "/filter";

            
        }

        public static class InHoaDon
        {
            private const string BaseEndpoint = "~/" + AreaName + "/in-hoa-don";
            public const string FilterInHoaDon = BaseEndpoint + "/filter-in-hoa-don";
            public const string GetAllInHoaDon = BaseEndpoint + "/get-all";
            public const string AddHoaDon = BaseEndpoint + "/in-hoa-don";
            public const string InKetHoaDon = BaseEndpoint + "/in-ket-hoa-don";
            public const string InLaiHoaDon = BaseEndpoint + "/in-lai-hoa-don";
            public const string InLaiHoaDonTheoMaKhachhang = BaseEndpoint + "/in-lai-hoa-don-theo-ma-khach-hang";
            public const string FetchInHoaDon = BaseEndpoint + "/fetch-data-in-lai-hoa-don";
        }

        public static class Vung
        {
            private const string BaseEndpoint = "~/" + AreaName + "/vung";
            public const string GetVung = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllVung = BaseEndpoint + "/get-all";
            public const string GetVungByNhaMayId = BaseEndpoint + "/get-vung-by-nha-may-id";
            public const string AddVung = BaseEndpoint + "/add";
            public const string UpdateVung = BaseEndpoint + "/update";
            public const string DeleteVung = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class NhaMay
        {
            private const string BaseEndpoint = "~/" + AreaName + "/nha-may";
            public const string GetNhaMay = BaseEndpoint + "/get-single/{keyId}";
            public const string GetNhaMayByUserId = BaseEndpoint + "/get-by-userid/{userId}";
            public const string GetAllNhaMay = BaseEndpoint + "/get-all";
            public const string AddNhaMay = BaseEndpoint + "/add";
            public const string ReMapNhaMay = BaseEndpoint + "/remapping";
            public const string UpdateNhaMay = BaseEndpoint + "/update";
            public const string UpdateDanhSachToaDo = BaseEndpoint + "/update-danh-sach-toa-do";

            public const string DeleteNhaMay = BaseEndpoint + "/delete" + "/{keyId}";

        }

        public static class DanhSachDoiTuongGia
        {
            private const string BaseEndpoint = "~/" + AreaName + "/danh-sach-doi-tuong-gia";
            public const string GetDanhSachDoiTuongGia = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllDanhSachDoiTuongGia = BaseEndpoint + "/get-all";
            public const string AddDanhSachDoiTuongGia = BaseEndpoint + "/add";
            public const string UpdateDanhSachDoiTuongGia = BaseEndpoint + "/update";
            public const string DeleteDanhSachDoiTuongGia = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class NhatKyDuLieu
        {
            private const string BaseEndpoint = "~/" + AreaName + "/nhat-ky-du-lieu";
            public const string GetNhatKyDuLieu = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllNhatKyDuLieu = BaseEndpoint + "/get-all";
            public const string AddNhatKyDuLieu = BaseEndpoint + "/add";
            public const string UpdateNhatKyDuLieu = BaseEndpoint + "/update";
            public const string DeleteNhatKyDuLieu = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class KhachHang
        {
            private const string BaseEndpoint = "~/" + AreaName + "/khach-hang";
            public const string GetKhachHang = BaseEndpoint + "/get-single/{keyId}";
            public const string GetKhachHangWithDongHos = BaseEndpoint + "/get-single-with-dong-ho/{keyId}";
            public const string GetAllKhachHang = BaseEndpoint + "/get-all";
            public const string GetMaKhachHangByNhaMayId = BaseEndpoint + "/get-ma-khach-hang/{nhaMayId}";
            public const string AddKhachHang = BaseEndpoint + "/add";
            public const string UpdateKhachHang = BaseEndpoint + "/update";
            public const string UpdateIDTheDienLucForKhachHang = BaseEndpoint + "/update-the-dien-luc";
            public const string DeleteKhachHang = BaseEndpoint + "/delete" + "/{keyId}";
            public const string GetKHByCMND = BaseEndpoint + "/getByCMND" + "/{cmnd}";
        }

       

        public static class TuyenDoc
        {
            private const string BaseEndpoint = "~/" + AreaName + "/tuyen-doc";
            public const string GetTuyenDoc = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllTuyenDoc = BaseEndpoint + "/get-all";
            public const string GetAllTuyenDocByNhaMayIds = BaseEndpoint + "/get-all-by-nha-may";
            public const string GetTuyenDocChuaCoCanBoQuanLy = BaseEndpoint + "/get-all-tuyen-doc-dont-have-can-bo-doc";
            public const string UpdateTuyenDocForCanBo = BaseEndpoint + "/update-tuyen-doc-chua-co-can-bo-quan-ly";
            public const string GetTuyenDocChuaTaoSo = BaseEndpoint + "-chua-tao-so/get-all";
            public const string GetTuyenDocsByNhaMay = BaseEndpoint + "/get-by-nha-may";
            public const string GetTuyenDocById = BaseEndpoint + "/get-by-id";


            public const string GetAllTuyenDocByKhuVucId = BaseEndpoint + "/get-by-khuvucid/{khuVucId}";
            public const string GetAllTuyenDocByKhuVucIdV2 = BaseEndpoint + "/get-by-khuvucid-v2/{khuVucId}";
            public const string GetTuyenDocWithDataKhuVucAndVung = BaseEndpoint + "/get-single-and-relationship/{keyId}";
            public const string AddTuyenDoc = BaseEndpoint + "/add";
            public const string UpdateTuyenDoc = BaseEndpoint + "/update";
            public const string UpdateNguoiQuanLyChoTuyenDoc = BaseEndpoint + "/update/{nhaMayId}/nguoiQuanLyId";
            public const string UpdateNguoiQuanLyChoDanhMucTuyenDoc = BaseEndpoint + "/update-nguoi-quan-ly-cho-danh-muc-tuyen-doc";
            public const string UpdateNguoiThuTienChoDanhMucTuyenDoc = BaseEndpoint + "/update-nguoi-thu-tien-cho-danh-muc-tuyen-doc";
            public const string DeleteTuyenDoc = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class KhuVuc
        {
            private const string BaseEndpoint = "~/" + AreaName + "/khu-vuc";
            public const string GetKhuVuc = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllKhuVuc = BaseEndpoint + "/get-all";
            public const string GetKhuVucAndVung = BaseEndpoint + "/get-khu-vuc-and-vung";

            public const string GetAllKhuVucByNhaMayIds = BaseEndpoint + "/get-all-khu-vuc-by-nha-may-id/{nhaMayId}";
            public const string GetAllKhuVucByVungId = BaseEndpoint + "/get-by-vungid/{vungId}";
            public const string GetKhuVucWithDataVung = BaseEndpoint + "/get-single-and-relationship/{keyId}";
            public const string AddKhuVuc = BaseEndpoint + "/add";
            public const string UpdateKhuVuc = BaseEndpoint + "/update";
            public const string DeleteKhuVuc = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class DoiTuongGia
        {
            private const string BaseEndpoint = "~/" + AreaName + "/doi-tuong-gia";
            public const string GetDoiTuongGia = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllDoiTuongGia = BaseEndpoint + "/get-all";
            public const string AddDoiTuongGia = BaseEndpoint + "/add";
            public const string AddDoiTuongGiaAndChiTietGia = BaseEndpoint + "/add-doi-tuong-gia-and-chi-tiet-gia";
            public const string UpdateDoiTuongGia = BaseEndpoint + "/update";
            public const string UpdateDoiTuongGiaAndChiTietGia = BaseEndpoint + "/update-doi-tuong-gia-and-chi-tiet-gia";

            public const string DeleteDoiTuongGia = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class HopDong
        {
            public const string GetDataFilterForGetHopDong = BaseEndpoint + "/data-filter-get-hop-dong";
            private const string BaseEndpoint = "~/" + AreaName + "/hop-dong";
            public const string GetHopDongByKeyId = BaseEndpoint + "/get-single/{keyId}";
            public const string GetHopDongById = BaseEndpoint + "/get-single-id/{Id}";
            public const string GetAllHopDong = BaseEndpoint + "/get-all";
            public const string GetAllHopDongVer2 = BaseEndpoint + "/get-all-ver-2";
            public const string GetExcelQuanLyHopDong = BaseEndpoint + "/get-excel-quan-ly-hop-dong";
            public const string GetKhachHangMoi = BaseEndpoint + "/get-khach-hang-moi";
            public const string GetBangKeDanhSachKhachHang = BaseEndpoint + "/get-bang-ke-ds-khach-hang";
            public const string AddHopDong = BaseEndpoint + "/add";
            public const string AddHopDongWithThreeModel = BaseEndpoint + "/add-hop-dong-voi-ba-model";
            public const string UpdateHopDong = BaseEndpoint + "/update";
            public const string UpdateHopDongWithKhachHangAndDongHoNuoc = BaseEndpoint + "/update-hop-dong-voi-ba-model" + "/{hopDongKeyId}" + "/{dongHoKeyId}";
            public const string DeleteHopDong = BaseEndpoint + "/delete" + "/{keyId}";
            public const string DeleteHopDongWithDongHoNuocs = BaseEndpoint + "/delete-with-dong-ho-nuoc" + "/{keyId}";
            public const string ChuyenNhuongHopDong = BaseEndpoint + "/chuyen-nhuong-hop-dong";
            public const string TaoHopDongRong = BaseEndpoint + "/tao-hop-dong-rong";
            public const string taoKeyIdHopDong = BaseEndpoint + "/tao-keyid-hop-dong";
            public const string FilterHopDongForCreateSoDoc = BaseEndpoint + "/filter-hop-dong-for-create-so-doc";
            public const string FilterHopDong = BaseEndpoint + "/filter-hop-dong";
            public const string DashBoardHopDong = BaseEndpoint + "/so-luong-hop-dong";
            public const string CreateHopDongVer2 = BaseEndpoint + "/tao-hop-dong-ver-2";
            public const string GetDetailsHopDongVer2 = BaseEndpoint + "/details-hop-dong-ver-2";
            public const string UpdateHopDongVer2 = BaseEndpoint + "/cap-nhat-hop-dong-sp";
            public const string DownloadBienBanThoaThuan = BaseEndpoint + "/in-bien-ban-thoa-thuan";

            public const string ExportDocsInHopDong = BaseEndpoint + "/in-hop-dong";
        }

        public static class SuCo
        {
            private const string BaseEndpoint = "~/" + AreaName + "/su-co";
            public const string GetSuCo = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllSuCo = BaseEndpoint + "/get-all";
            public const string AddSuCo = BaseEndpoint + "/add";
            public const string UpdateSuCo = BaseEndpoint + "/update";
            public const string DeleteSuCo = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class DongHoNuocSuCo
        {
            private const string BaseEndpoint = "~/" + AreaName + "/dong-ho-nuoc-su-co";
            public const string GetDongHoNuocSuCo = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllDongHoNuocSuCo = BaseEndpoint + "/get-all";
            public const string AddDongHoNuocSuCo = BaseEndpoint + "/add";
            public const string UpdateDongHoNuocSuCo = BaseEndpoint + "/update";
            public const string DeleteDongHoNuocSuCo = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class DongHoNuoc
        {
            private const string BaseEndpoint = "~/" + AreaName + "/dong-ho-nuoc";
            public const string GetDongHoNuoc = BaseEndpoint + "/get-single/{keyId}";
            public const string GetDongHoNuocBySeri = BaseEndpoint + "/get-dongho-bySeri/{Seri}";
            public const string GetDongHoNuocByKeyId = BaseEndpoint + "/get-dongho-byKeyId/{KeyId}";
            public const string GetDongHoNuocByHopDongKeyId = BaseEndpoint + "/get-by/hop-dong/{keyId}";
            public const string GetAllDongHoNuoc = BaseEndpoint + "/get-all";
            public const string GetAllDongHoBlock = BaseEndpoint + "/get-all-block";
            public const string GetAllDongHoNuocToExcel = BaseEndpoint + "/get-all-to-excel";
            public const string GetDongHoNuocByKhachHangKeyId = BaseEndpoint + "/get-by/khach-hang/{keyId}";
            public const string GetDongHoNuocAutoGenerateKeyIdByHopDongId = BaseEndpoint + "/get-auto-generate-keyId-by" + "/{hopDongId}";
            public const string GetDongHoTongByNhaMayId = "~/" + AreaName + "/dong-ho-tong/get-by/nha-may-id";
            public const string GetDongHoNuocsTheoLoaiDongHo = BaseEndpoint + "/get-all" + "/loai-dong-ho/{loaiDongHo}";
            public const string GetDongHoBlocksByNhaMay = BaseEndpoint + "/get-dong-ho-blocks-by-nha-may";

            public const string AddDongHoNuoc = BaseEndpoint + "/add";
            public const string AddDongHoNuocWithAutoGenerateKeyId = BaseEndpoint + "/add-with-auto-generate-keyId";
            public const string AddDongHoTong = BaseEndpoint + "/add-dong-ho-tong";
            public const string UpdateDongHoNuoc = BaseEndpoint + "/update";
            public const string ChangeDongHoTong = BaseEndpoint + "/update-dong-ho-tong";
            public const string ChangeDongHoNuoc = BaseEndpoint + "/change";
            public const string DeleteDongHoNuoc = BaseEndpoint + "/delete" + "/{keyId}";
            public const string AddDongHoBlock = BaseEndpoint + "/add-dong-ho-block";
            public const string UpdateDongHoBlock = BaseEndpoint + "/update-dong-ho-block";
            public const string GetDongHoBlockByTuyen = BaseEndpoint + "/get-dong-ho-block-theo-tuyen";
            public const string UpdateDongHoBlockKinhDoViDo = BaseEndpoint + "/update-dong-ho-block-tong-kinh-vi-do";
            public const string UpdateDongHoCuDanKinhDoViDo = BaseEndpoint + "/update-dong-ho-kinh-vi-do";
            public const string AddChipClockToClock = BaseEndpoint + "/add-chip-dong-ho-nuoc-vao-dong-ho";

            public const string GetDongHoBlockAndTuyenTheoNhaMay = BaseEndpoint + "/get-tuyen-doc-and-dong-ho-nuoc";
            public const string GetThongKeDongHoNuocTheoTuyenVaNhaMay = BaseEndpoint + "/thong-ke-dong-ho-theo-tuyen-va-nha-may";
            public const string GetThongKeDoanhThuTheoThangVaNhaMay = BaseEndpoint + "/thong-ke-doanh-thu-theo-tung-thang-va-nha-may";
            public const string GetThongKeDoanhThuGiuaHaiThang = BaseEndpoint + "/thong-ke-doanh-thu-theo-giua-hai-thang-cua-nha-may";
            public const string GetThongKeDoanhThuGiuaHaiNam = BaseEndpoint + "/thong-ke-doanh-thu-theo-giua-hai-nam-cua-nha-may";
            public const string GetThongKeTieuThuNhaMay = BaseEndpoint + "/thong-ke-tieu-thu-theo-tung-thang-va-nha-may";
          
        }

        public static class ChiTietGia
        {
            private const string BaseEndpoint = "~/" + AreaName + "/chi-tiet-gia";
            public const string GetChiTietGia = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllChiTietGia = BaseEndpoint + "/get-all";
            public const string GetChiTietGiaByDoiTuongGia = BaseEndpoint + "/get-by-doi-tuong-gia";
            public const string AddChiTietGia = BaseEndpoint + "/add";
            public const string UpdateChiTietGia = BaseEndpoint + "/update";
            public const string DeleteChiTietGia = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class ThatThoat
        {
            private const string BaseEndpoint = "~/" + AreaName + "/that-thoat";
            public const string GetThatThoat = BaseEndpoint + "/get-single/{keyId}";
            public const string GetTiLeThatThoatMoiThang = BaseEndpoint + "/ti-le-that-thoat-dashboard";
        
            public const string GetAllThatThoat = BaseEndpoint + "/get-all";
            public const string AddThatThoat = BaseEndpoint + "/add-cho-dong-ho-block";
            public const string AddThatThoatChoDongHoTong = BaseEndpoint + "/add-cho-dong-ho-tong";
            public const string UpdateThatThoat = BaseEndpoint + "/update-cho-tong-va-block";
            public const string DeleteThatThoat = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class ChiSoDongHo
        {
            private const string BaseEndpoint = "~/" + AreaName + "/chi-so-dong-ho";
            public const string GetChiSoDongHo = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllChiSoDongHo = BaseEndpoint + "/get-all";
            public const string AddChiSoDongHo = BaseEndpoint + "/add";
            public const string UpdateChiSoDongHo = BaseEndpoint + "/update";
            public const string DeleteChiSoDongHo = BaseEndpoint + "/delete" + "/{keyId}";
            public const string GetChiSoDongHoBySoDocChiSoId = BaseEndpoint + "/get-chi-so-dong-ho-by-so-doc-chi-so-id";
            public const string GetChiSoDongHoBySoDocChiSoIdV2 = BaseEndpoint + "/get-chi-so-dong-ho-by-so-doc-chi-so-id-v2";
            public const string GetChiSoDongHoById = BaseEndpoint + "/get-chi-so-dong-ho-by-id/{id}";
            public const string GetChiSoDongHoByIdWithToaDo = BaseEndpoint + "/get-chi-so-dong-ho-by-id-with-toa-do/{id}";
            public const string GetChiSoDongHoBlockById = BaseEndpoint + "/get-chi-so-dong-ho-block-by-id/{id}";
            public const string GetChiSoDongHoTongById = BaseEndpoint + "/get-chi-so-dong-ho-tong-by-id/{id}";
            public const string FilterChiSo = BaseEndpoint + "/filter";
            public const string FilterNhapChiSo = BaseEndpoint + "/filter-nhap-chi-so";
            public const string XemTinhHinhNuoc = BaseEndpoint + "/filter-xem-tinh-hinh-nuoc";
            public const string GetChiSoDongHoByNhaMayId = BaseEndpoint + "/get-chi-so-dong-ho-by-nha-may-id";
            public const string GetAlLChiSoDongHoByChipDongHoNuocId = BaseEndpoint + "/get-chi-so-dong-ho-by-chip-dong-ho-nuoc/{chipDongHoNuocId}";
            public const string GetChiSoDongHoByChipDongHoNuocId = BaseEndpoint + "/get-chi-so-dong-ho-by-chip-dong-ho-nuoc-and-thang-tao-so/{chipDongHoNuocId}";
            public const string GetChiSoDongHoBySoDocChiSoDongHoBlockVaTong = BaseEndpoint + "/get-chi-so-dong-ho-by-so-doc-chi-so-dong-ho-block-va-tong-id";
            public const string ExportExcel = BaseEndpoint + "/export-excel";
            public const string GetTieuThuTheoTungThang = BaseEndpoint + "/tieu-thu-theo-thang";
            public const string GetAllVer2 = BaseEndpoint + "/get-all-chi-so-dongho-by-so-doc-id-ver2";
            public const string UpdateChiSoDongHoWithDongHoNuocInfo = BaseEndpoint + "/update-chi-so-dong-ho-with-dong-ho-nuoc-info";
            public const string PutChiSoMoi = BaseEndpoint + "/put-chi-so-moi";

        }

        public static class SoDocChiSo
        {
            private const string BaseEndpoint = "~/" + AreaName + "/so-doc-chi-so";
            public const string GetSoDocChiSo = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllSoDocChiSo = BaseEndpoint + "/get-all";
            public const string GetDataFilterGetSoDoc = BaseEndpoint + "/data-filter-get-so-doc";
            public const string GetAllSoDocChiSoVer2 = BaseEndpoint + "/get-all-ver2";
            public const string GetAllSoThanhToanByNhaMay = BaseEndpoint + "/get-all-so-thanh-toan";
            public const string GetAllSoThanhToanByNhaMayV2 = BaseEndpoint + "/get-all-so-thanh-toan-mobile";

            public const string FilterSoThanhToan = BaseEndpoint + "/filter-so-thanh-toan";
            public const string FilterSoThanhToanMobile = BaseEndpoint + "/filter-so-thanh-toan-mobile";

            public const string GetSoDocChiSoTheoLoaiDongHo = BaseEndpoint + "/get-all-theo-loai-dong-ho";
            public const string FilterSoDocChiSoDHBlock = BaseEndpoint + "/filter-so-doc-chi-so-cua-dong-ho-block";
            public const string FilterSoDocChiSoDHTong = BaseEndpoint + "/filter-so-doc-chi-so-cua-dong-ho-tong";
            public const string AddSoDocChiSo = BaseEndpoint + "/Create-So-Doc-Chi-So";
            public const string CreateSoDocChiSoDongLoat = BaseEndpoint + "/create-so-doc-chi-so-dong-loat";
            public const string CreateSoDocChiSoChoDongHoTong = BaseEndpoint + "/create-so-doc-chi-so-dong-ho-tong";
            public const string CreateSoDocChiSoChoDongHoBlock = BaseEndpoint + "/create-so-doc-chi-so-dong-ho-block";
            public const string CreateNewSoDocChiSo = BaseEndpoint + "/create-new-so-doc-chi-so";
            public const string SynchronizedSoDocChiSo = BaseEndpoint + "/synchronized";
            public const string UpdateSoDocChiSo = BaseEndpoint + "/update";
            public const string DeleteSoDocChiSo = BaseEndpoint + "/delete" + "/{keyId}";
            public const string GetKyGhiChiSoDeTaoSoDocChiSo = BaseEndpoint + "/get-ky-ghi-chi-so-de-tao-so-doc" + "/{id}";
            public const string GetListTaoSoDongLoat = BaseEndpoint + "/get-list-tao-so-dong-loat";
            public const string UpdateKhoaSo = BaseEndpoint + "/khoa-so-theo-so-doc-id";
            public const string UpdateMoSo = BaseEndpoint + "/mo-so-theo-so-doc-id";
            public const string UpdateChotSoStatus = BaseEndpoint + "/update/chot-so-so-doc-chi-so";
            public const string GetSoDocWithSoDongHoDaGhi = BaseEndpoint + "/get-so-doc-va-so-dong-ho-da-ghi";
            public const string CreateNgayTrongSoDocChiSoByKyGhiChiSoId = BaseEndpoint + "/tao-ngay-trong-so-doc-theo-ky";
            public const string FilterSoDocChiSo = BaseEndpoint + "/filter";
            public const string GetSoDocChiSoByNhaMayId = BaseEndpoint + "/get-so-doc-chi-so-by-nha-may-id";
            public const string GetSoDocChiSoByNhaMayIdV2 = BaseEndpoint + "/get-so-doc-chi-so-by-nha-may-id-V2";
            public const string GhiChiSoDongHo = BaseEndpoint + "/chi-so-dong-ho/ghi-chi-so";
            public const string GhiChiSoDongHoByExcel = BaseEndpoint + "/chi-so-dong-ho/ghi-chi-so-file-excel";
            public const string DeleteSoDoc = BaseEndpoint + "/delete-so-doc";
            public const string UpdateTrangThaiKhoaSoCuaTongVaBlock = BaseEndpoint + "/update/khoa-so-so-doc-chi-so-cho-dong-ho-tong-va-block";
            public const string UpdateTrangThaiMoKhoaSoCuaTongVaBlock = BaseEndpoint + "/update/mo-khoa-so-so-doc-chi-so-cho-dong-ho-tong-va-block";
            public const string UpdateImageChiSo = BaseEndpoint + "/update/image-chi-so";
            public const string UpdateImageChiSoToLocal = BaseEndpoint + "/update/image-chi-so-local";
        }

        public static class TrangThaiGhi
        {
            private const string BaseEndpoint = "~/" + AreaName + "/trang-thai-ghi";
            public const string GetTrangThaiGhi = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllTrangThaiGhi = BaseEndpoint + "/get-all";
            public const string AddTrangThaiGhi = BaseEndpoint + "/add";
            public const string UpdateTrangThaiGhi = BaseEndpoint + "/update";
            public const string DeleteTrangThaiGhi = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class KyGhiChiSo
        {
            private const string BaseEndpoint = "~/" + AreaName + "/ky-ghi-chi-so";
            public const string GetKyGhiChiSo = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllKyGhiChiSo = BaseEndpoint + "/get-all";
            public const string AddKyGhiChiSo = BaseEndpoint + "/add";
            public const string UpdateKyGhiChiSo = BaseEndpoint + "/update";
            public const string DeleteKyGhiChiSo = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class DanhMucSeriHoaDon
        {
            private const string BaseEndpoint = "~/" + AreaName + "/danh-muc-seri-hoa-don";
            public const string GetDanhMucSeriHoaDon = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllDanhMucSeriHoaDon = BaseEndpoint + "/get-all";
            public const string AddDanhMucSeriHoaDon = BaseEndpoint + "/add";
            public const string UpdateDanhMucSeriHoaDon = BaseEndpoint + "/update";
            public const string DeleteDanhMucSeriHoaDon = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class PhienInThongBao
        {
            private const string BaseEndpoint = "~/" + AreaName + "/phien-in-thong-bao";
            public const string GetPhienInThongBao = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllPhienInThongBao = BaseEndpoint + "/get-all";
            public const string AddPhienInThongBao = BaseEndpoint + "/add";
            public const string UpdatePhienInThongBao = BaseEndpoint + "/update";
            public const string DeletePhienInThongBao = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class HoaDon
        {
            private const string BaseEndpoint = "~/" + AreaName + "/hoa-don";
            public const string GetHoaDon = BaseEndpoint + "/get-single/{id}";
            public const string GetHoaDonForUpdate = BaseEndpoint + "/get-hoa-don-for-update/{Id}";
            public const string GetHoaDonDetails = BaseEndpoint + "/get-single/{id}/details";
            public const string GetHoaDonDetailsByThanhToanId = BaseEndpoint + "/get-single/thanh-toan/{thanhToanId}/details";
            public const string PrintHoaDon = BaseEndpoint + "/print-hoa-don/{Id}";
            public const string GetAllHoaDon = BaseEndpoint + "/get-all";
            public const string GetAllHoaDonChuaThanhToanForChipDongHoId = BaseEndpoint + "/get-all-hoa-don-chua-thanh-toan-by-chip-dong-ho-id/{chipDongHoId}";
            public const string GetAllHoaDonChuaThanhToanForIDTheDienLuc = BaseEndpoint + "/get-all-hoa-don-chua-thanh-toan-by-id-the-dien-luc/{IDtheDienLuc}";
            public const string GetAllHoaDonBySoDocChiSoIdVaNhaMayIds = BaseEndpoint + "/get-all-so-thanh-toan";
            public const string FilterSoThanhToan = BaseEndpoint + "/filter-so-thanh-toan";
            public const string AddHoaDon = BaseEndpoint + "/tinh-tien-hoa-don";
            public const string AddNewHoaDon = BaseEndpoint + "/add";
            public const string UpdateHoaDon = BaseEndpoint + "/update";
            public const string SynchronizedHoaDon = BaseEndpoint + "/synchronized";
            public const string DeleteHoaDon = BaseEndpoint + "/delete" + "/{keyId}";
            public const string FilterHoaDon = BaseEndpoint + "/filter";
            public const string GetAllHoaDonChuaThanhToanByMaKhachHang = BaseEndpoint + "/get-all-hoa-don-chua-thanh-toan-by-ma-khach-hang/{maKhachHang}";
            public const string FetchDataForMenuHoaDon = BaseEndpoint + "/fetch-data-for-menu-hoa-don";
            public const string GetAllHoaDonVer2FormSP = BaseEndpoint + "/get-all-hoa-don-ver-2";
            public const string UpdateHoaDonTrangThaiThanhToan = BaseEndpoint + "/thanh-toan-hoa-don";
            public const string UpdateHoaDonTrangThaiThanhToanToChuaThanhToan = BaseEndpoint + "/update-thanh-toan-hoa-don-to-chua-thanh-toan";
            public const string UpdateHoaDonTrangThaiDuyetHoaDon = BaseEndpoint + "/duyet-hoa-don";
            public const string GetAllHoaDonChuaThanhToanForMobile = BaseEndpoint + "/get-hoa-don-for-mobile";
        }

        public static class DanhMucThongBao
        {
            private const string BaseEndpoint = "~/" + AreaName + "/danh-muc-thong-bao";
            public const string GetDanhMucThongBao = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllDanhMucThongBao = BaseEndpoint + "/get-all";
            public const string AddDanhMucThongBao = BaseEndpoint + "/add";
            public const string UpdateDanhMucThongBao = BaseEndpoint + "/update";
            public const string DeleteDanhMucThongBao = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class ThongBao
        {
            private const string BaseEndpoint = "~/" + AreaName + "/thong-bao";
            public const string GetThongBao = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllThongBao = BaseEndpoint + "/get-all";
            public const string AddThongBao = BaseEndpoint + "/add";
            public const string UpdateThongBao = BaseEndpoint + "/update";
            public const string DeleteThongBao = BaseEndpoint + "/delete" + "/{keyId}";
        }
        
        public static class PhuongThucThanhToan
        {
            private const string BaseEndpoint = "~/" + AreaName + "/phuong-thuc-thanh-toan";
            public const string GetPhuongThucThanhToan = BaseEndpoint + "/get-single/{keyId}";
            public const string GetPhuongThucThanhToanById = BaseEndpoint + "/get-phuong-thuc-thanh-toan-by-id";
            public const string GetAllPhuongThucThanhToan = BaseEndpoint + "/get-all";
            public const string AddPhuongThucThanhToan = BaseEndpoint + "/add";
            public const string UpdatePhuongThucThanhToan = BaseEndpoint + "/update";
            public const string DeletePhuongThucThanhToan = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class DanhSachHoDan
        {
            private const string BaseEndpoint = "~/" + AreaName + "/danh-sach-ho-dan";
            public const string GetDanhSachHoDan = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllDanhSachHoDan = BaseEndpoint + "/get-all";
            public const string AddDanhSachHoDan = BaseEndpoint + "/add";
            public const string UpdateDanhSachHoDan = BaseEndpoint + "/update";
            public const string DeleteDanhSachHoDan = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class MauTinSMS
        {
            private const string BaseEndpoint = "~/" + AreaName + "/mau-tin-sms";
            public const string GetMauTinSMS = BaseEndpoint + "/get-single" + "/{id}";
            public const string GetAllMauTinSMS = BaseEndpoint + "/get-all";
            public const string AddMauTinSMS = BaseEndpoint + "/add";
            public const string TestSMS = BaseEndpoint + "/sendsms";
            public const string UpdateMauTinSMS = BaseEndpoint + "/update";
            public const string DeleteMauTinSMS = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class LichSuSMS
        {
            private const string BaseEndpoint = "~/" + AreaName + "/lich-su-sms";
            public const string GetLichSuSMS = BaseEndpoint + "/get-single" + "/{id}";
            public const string GetAllLichSuSMS = BaseEndpoint + "/get-all";
            public const string AddLichSuSMS = BaseEndpoint + "/add";
            public const string UpdateLichSuSMS = BaseEndpoint + "/update";
            public const string DeleteLichSuSMS = BaseEndpoint + "/delete" + "/{id}";
            public const string SendSMS = BaseEndpoint + "/sendSMS";
        }

        public static class NhatKyHoaDon
        {
            private const string BaseEndpoint = "~/" + AreaName + "/nhat-ky-hoa-don";
            public const string GetNhatKyHoaDon = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllNhatKyHoaDon = BaseEndpoint + "/get-all";
            public const string AddNhatKyHoaDon = BaseEndpoint + "/add";
            public const string UpdateNhatKyHoaDon = BaseEndpoint + "/update";
            public const string DeleteNhatKyHoaDon = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class ChiTietHoaDon
        {
            private const string BaseEndpoint = "~/" + AreaName + "/chi-tiet-hoa-don";
            public const string GetChiTietHoaDon = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllChiTietHoaDon = BaseEndpoint + "/get-all";
            public const string AddChiTietHoaDon = BaseEndpoint + "/add";
            public const string UpdateChiTietHoaDon = BaseEndpoint + "/update";
            public const string DeleteChiTietHoaDon = BaseEndpoint + "/delete" + "/{keyId}";
        }

        public static class NguoiDung
        {
            private const string BaseEndpoint = "~/" + AreaName + "/nguoi-dung";
            public const string GetNguoiDung = BaseEndpoint + "/get-single" + "/{id}";
            public const string GetAllNguoiDung = BaseEndpoint + "/get-all";
            public const string AddNguoiDung = BaseEndpoint + "/add";
            public const string UpdateNguoiDung = BaseEndpoint + "/update";
            public const string DeleteNguoiDung = BaseEndpoint + "/delete" + "/{keyId}";
        }
        public static class Tinh
        {
            private const string BaseEndpoint = "~/" + AreaName + "/tinh";
            public const string GetTinh = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllTinh = BaseEndpoint + "/get-all";
            public const string AddTinh = BaseEndpoint + "/add";
            public const string UpdateTinh = BaseEndpoint + "/update";
            public const string DeleteTinh = BaseEndpoint + "/delete" + "/{keyId}";
            public const string GetTinhHuyenXa = BaseEndpoint + "/get-tinh-huyen-xa";
        }
        public static class Huyen
        {
            private const string BaseEndpoint = "~/" + AreaName + "/huyen";
            public const string GetHuyen = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllHuyen = BaseEndpoint + "/get-all";
            public const string GetListHuyenByTinhId = BaseEndpoint + "/get-by-TinhId/{tinhId}";
            public const string AddHuyen = BaseEndpoint + "/add";
            public const string UpdateHuyen = BaseEndpoint + "/update";
            public const string DeleteHuyen = BaseEndpoint + "/delete" + "/{keyId}";
        }
        public static class Xa
        {
            private const string BaseEndpoint = "~/" + AreaName + "/xa";
            public const string GetXa = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllXa = BaseEndpoint + "/get-all";
            public const string GetListXaByHuyenId = BaseEndpoint + "/get-by-huyenId/{huyenId}";
            public const string AddXa = BaseEndpoint + "/add";
            public const string UpdateXa = BaseEndpoint + "/update";
            public const string DeleteXa = BaseEndpoint + "/delete" + "/{keyId}";
        }
        public static class PhamVi
        {
            private const string BaseEndpoint = "~/" + AreaName + "/pham-vi";
            public const string GetPhamVi = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllPhamVi = BaseEndpoint + "/get-all";
            public const string AddPhamVi = BaseEndpoint + "/add";
            public const string UpdatePhamVi = BaseEndpoint + "/update";
            public const string DeletePhamVi = BaseEndpoint + "/delete" + "/{keyId}";
        }
        public static class KieuDongHo
        {
            private const string BaseEndpoint = "~/" + AreaName + "/kieu-dong-ho";
            public const string GetKieuDongHo = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllKieuDongHo = BaseEndpoint + "/get-all";
            public const string AddKieuDongHo = BaseEndpoint + "/add";
            public const string UpdateKieuDongHo = BaseEndpoint + "/update";
            public const string DeleteKieuDongHo = BaseEndpoint + "/delete" + "/{keyId}";
        }
        public static class NuocSanXuat
        {
            private const string BaseEndpoint = "~/" + AreaName + "/nuoc-san-xuat";
            public const string GetNuocSanXuat = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllNuocSanXuat = BaseEndpoint + "/get-all";
            public const string AddNuocSanXuat = BaseEndpoint + "/add";
            public const string UpdateNuocSanXuat = BaseEndpoint + "/update";
            public const string DeleteNuocSanXuat = BaseEndpoint + "/delete" + "/{keyId}";
        }
        public static class HangSanXuat
        {
            private const string BaseEndpoint = "~/" + AreaName + "/hang-san-xuat";
            public const string GetHangSanXuat = BaseEndpoint + "/get-single/{keyId}";
            public const string GetAllHangSanXuat = BaseEndpoint + "/get-all";
            public const string AddHangSanXuat = BaseEndpoint + "/add";
            public const string UpdateHangSanXuat = BaseEndpoint + "/update";
            public const string DeleteHangSanXuat = BaseEndpoint + "/delete" + "/{keyId}";
        }
        public static class DanhMuc
        {
            private const string BaseEndpoint = "~/" + AreaName + "/danh-muc";
            public const string GetDanhMuc = BaseEndpoint + "/get-single/{id}";
            public const string GetAllDanhMuc = BaseEndpoint + "/get-all";
            public const string ActionsDanhMuc = BaseEndpoint + "/actions";
            public const string GetAllDanhMucByType = BaseEndpoint + "/get-all-by-type";
        }
        public static class TuyenOngNuoc
        {
            private const string BaseEndpoint = "~/" + AreaName + "/tuyen-ong-nuoc";
            public const string Add = BaseEndpoint + "/add";
            public const string Update = BaseEndpoint + "/update";
            public const string Delete = BaseEndpoint + "/delete" + "/{id}";
        }
        public static class SoDoMapTuyen
        {
            private const string BaseEndpoint = "~/" + AreaName + "/so-do-map-tuyen";
            public const string Get = BaseEndpoint + "/get-all-so-do-map-tuyen";
            public const string Add = BaseEndpoint + "/add";
            public const string Update = BaseEndpoint + "/update";
            public const string Delete = BaseEndpoint + "/delete";
        }
        public static class SoDoMapNhaMay
        {
            private const string BaseEndpoint = "~/" + AreaName + "/so-do-map-nha-may";
            public const string Get = BaseEndpoint + "/get-all-so-do-map-nha-may";
            public const string Add = BaseEndpoint + "/add";
            public const string Update = BaseEndpoint + "/update-thong-tin-chung";
            public const string UpdateTramCuuHoa = BaseEndpoint + "/update-tram-cuu-hoa";
            public const string UpdateVanChan = BaseEndpoint + "/update-van-chan";
            public const string UpdateTramBom = BaseEndpoint + "/update-tram-bom";
            public const string UpdateDiemDauNoi = BaseEndpoint + "/update-diem-dau-noi";
            public const string Delete = BaseEndpoint + "/delete";
        }
        public static class FilesManager
        {
            private const string BaseEndpoint = "~/" + AreaName + "/Upload";
            public const string Post = BaseEndpoint + "/add";
            //public const string Add = BaseEndpoint + "/add";
            public const string Update = BaseEndpoint + "/update";
            public const string Delete = BaseEndpoint + "/delete";
        }

        public static class PhongBan
        {
            private const string BaseEndpoint = "~/" + AreaName + "/phongban";
            public const string Add = BaseEndpoint + "/add";
            public const string GetAllPhongBan = BaseEndpoint + "/get-all";
            public const string GetByUserId = BaseEndpoint + "/get-by-user-id";


            public const string Update = BaseEndpoint + "/update";
            public const string Delete = BaseEndpoint + "/delete"+ "/{id}";
        }
    }
}
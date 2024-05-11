namespace DTO.Constants
{
    public class ApplicationConstants
    {
        public const string KEYID_EXISTED = "KeyId {0} đã tồn tại.";
        public const string KeyId = "KeyId";
        public const string DUPLICATE = "Symtem_id is duplicated";
    }

    public class ResponseCodeConstants
    {
        public const string NOT_FOUND = "Not found!";
        public const string SUCCESS = "Success!";
        public const string FAILED = "Failed!";
        public const string EXISTED = "Existed!";
        public const string DUPLICATE = "Duplicate!";
        public const string INTERNAL_SERVER_ERROR = "INTERNAL_SERVER_ERROR";
        public const string INVALID_INPUT = "Invalid input!";
        public const string UNAUTHORIZED = "Unauthorized!";
    }
    public class ReponseMessageConstantsCommon
    {
        public const string EXISTED = "Already existed!";
    }
    public class ReponseMessageConstantsVung
    {
        public const string VUNG_NOT_FOUND = "Khong tim thay vung.";
        public const string VUNG_EXISTED = "Vung da ton tai.";
        public const string UPDATE_VUNG_SUCCESS = "Cap nhat vung thanh cong.";
        public const string DELETE_VUNG_SUCCESS = "Xoa vung thanh cong.";
    }

    public class ReponseMessageConstantsDanhSachDoiTuongGia
    {
        public const string DANH_SACH_DOI_TUONG_GIA_NOT_FOUND = "Khong tim thay danh sach doi tuong gia.";
        public const string DANH_SACH_DOI_TUONG_GIA_EXISTED = "Danh sach doi tuong gia da ton tai.";
        public const string UPDATE_DANH_SACH_DOI_TUONG_GIA_SUCCESS = "Cap nhat danh sach doi tuong gia thanh cong.";
        public const string DANH_SACH_DANH_SACH_DOI_TUONG_GIA_NOT_FOUND = "Khong tim thay danh sach doi tuong gia.";
        public const string DELETE_DANH_SACH_DOI_TUONG_GIA_SUCCESS = "Xoa danh sach doi tuong gia thanh cong.";
    }
    public class ReponseMessageConstantsPhongBan
    {
        public const string PHONG_BAN_NOT_FOUND = "Khong tim thay phong ban.";
    }

    public class ReponseMessageConstantsNhaMay
    {
        public const string NHA_MAY_NOT_FOUND = "Khong tim thay nha may.";
        public const string NHA_MAY_EXISTED = "Nha may da ton tai.";
        public const string UPDATE_NHA_MAY_SUCCESS = "Cap nhat nha may thanh cong.";
        public const string DELETE_NHA_MAY_SUCCESS = "Xoa nha may thanh cong.";
        public const string SOME_NHA_MAY_NOT_FOUND = "Mot vai nha may khong tim thay";
    }

    public class ReponseMessageConstantsNhatKyDuLieu
    {
        public const string NHAT_KY_DU_LIEU_NOT_FOUND = "Khong tim thay nhat ky du lieu.";
        public const string NHAT_KY_DU_LIEU_EXISTED = "Nhat ky du lieu da ton tai.";
        public const string UPDATE_NHAT_KY_DU_LIEU_SUCCESS = "Cap nhat nhat ky du lieu thanh cong.";
        public const string DELETE_NHAT_KY_DU_LIEU_SUCCESS = "Xoa nhat ky du lieu thanh cong.";
    }

    public class ReponseMessageConstantsKhachHang
    {
        public const string KHACH_HANG_NOT_FOUND = "Khong tim thay khach hang.";
        public const string KHACH_HANG_EXISTED = "Khach hang da ton tai.";
        public const string KHACH_HANG_EXISTED_CONTRACT = "Khach hang da ton tai hop dong dang su dung.";
        public const string UPDATE_KHACH_HANG_SUCCESS = "Cap nhat khach hang thanh cong.";
        public const string DELETE_KHACH_HANG_SUCCESS = "Xoa khach hang thanh cong.";
        public const string ID_HIEU_LUC_KHACH_HANG = "ID hieu luc khach hang khong duoc trung";
    }

    

    public class ReponseMessageConstantsKhuVuc
    {
        public const string KHU_VUC_NOT_FOUND = "Khong tim thay khu vuc.";
        public const string KHU_VUC_EXISTED = "Khu vuc da ton tai.";
        public const string UPDATE_KHU_VUC_SUCCESS = "Cap nhat khu vuc thanh cong.";
        public const string DELETE_KHU_VUC_SUCCESS = "Xoa khu vuc thanh cong.";
    }

    public class ReponseMessageConstantsTuyenDoc
    {
        public const string TUYEN_DOC_NOT_FOUND = "Khong tim thay tuyen doc.";
        public const string BLOCK_NOTFOUND = "Khong tim thay Dong Ho Block cho Tuyen Doc. Vui Long Tao Dong Ho Block cho Tuyen";
        public const string TUYEN_DOC_EXISTED = "Tuyen doc da ton tai.";
        public const string KHUVUC_NOT_EXISTED = "Khu vuc voi Id:{0} khong ton tai.";
        public const string UPDATE_TUYEN_DOC_SUCCESS = "Cap nhat tuyen doc thanh cong.";
        public const string DELETE_TUYEN_DOC_SUCCESS = "Xoa tuyen doc thanh cong.";
        public const string DONG_HO_BLOCK_EXISTED = "Tuyen nay da co dong ho block";
    }

    public class ReponseMessageConstantsDoiTuongGia
    {
        public const string DOI_TUONG_GIA_NOT_FOUND = "Khong tim thay doi tuong gia.";
        public const string DOI_TUONG_GIA_EXISTED = "Doi tuong gia da ton tai.";
        public const string UPDATE_DOI_TUONG_GIA_SUCCESS = "Cap nhat doi tuong gia thanh cong.";
        public const string DELETE_DOI_TUONG_GIA_SUCCESS = "Xoa doi tuong gia thanh cong.";
    }

    public class ReponseMessageConstantsHopDong
    {
        public const string HOP_DONG_NOT_FOUND = "Khong tim thay hop dong.";
        public const string HOP_DONG_EXISTED = "hop dong da ton tai.";
        public const string UPDATE_HOP_DONG_SUCCESS = "Cap nhat hop dong thanh cong.";
        public const string DELETE_HOP_DONG_SUCCESS = "Xoa hop dong thanh cong.";
        public const string CHUYEN_NHUONG_HOP_DONG_SUCCESS = "Chuyen nhuong hop dong thanh cong.";
        public const string KHONG_CO_DONG_HO_NUOC = "Khong co dong ho nuoc tai hop dong nay.";
        public const string HOP_DONG_NOT_EMPTY = "Hop dong nay khong phai hop dong rong";

    }

    public class ReponseMessageConstantsSuCo
    {
        public const string SU_CO_NOT_FOUND = "Khong tim thay su co.";
        public const string SU_CO_EXISTED = "su co da ton tai.";
        public const string UPDATE_SU_CO_SUCCESS = "Cap nhat su co thanh cong.";
        public const string DELETE_SU_CO_SUCCESS = "Xoa su co thanh cong.";
    }

    public class ReponseMessageConstantsDongHoNuocSuCo
    {
        public const string DONG_HO_NUOC_SU_CO_NOT_FOUND = "Khong tim thay dong ho nuoc su co.";
        public const string DONG_HO_NUOC_SU_CO_EXISTED = "dong ho nuoc su co da ton tai.";
        public const string UPDATE_DONG_HO_NUOC_SU_CO_SUCCESS = "Cap nhat dong ho nuoc su co thanh cong.";
        public const string DELETE_DONG_HO_NUOC_SU_CO_SUCCESS = "Xoa dong ho nuoc su co thanh cong.";
    }

    public class ReponseMessageConstantsDongHoNuoc
    {
        public const string DONG_HO_NUOC_NOT_FOUND = "Khong tim thay dong ho nuoc.";
        public const string DONG_HO_NUOC_EXISTED = "dong ho nuoc da ton tai.";
        public const string UPDATE_DONG_HO_NUOC_SUCCESS = "Cap nhat dong ho nuoc thanh cong.";
        public const string DELETE_DONG_HO_NUOC_SUCCESS = "Xoa dong ho nuoc thanh cong.";
        public const string CHIP_DONG_HO_NUOC_KHONG_DUOC_TRUNG = "Chip dong ho nuoc khong trung";
    }
    
    public class ReponseMessageConstantsChiTietGia
    {
        public const string CHI_TIET_GIA_NOT_FOUND = "Khong tim thay chi tiet gia.";
        public const string CHI_TIET_GIA_EXISTED = "Chi tiet gia da ton tai.";
        public const string UPDATE_CHI_TIET_GIA_SUCCESS = "Cap nhat chi tiet gia thanh cong.";
        public const string DELETE_CHI_TIET_GIA_SUCCESS = "Xoa chi tiet gia thanh cong.";
    }

    public class ReponseMessageConstantsThatThoat
    {
        public const string THAT_THOAT_NOT_FOUND = "Khong tim thay that thoat.";
        public const string THAT_THOAT_EXISTED = "that thoat da ton tai.";
        public const string UPDATE_THAT_THOAT_SUCCESS = "Cap nhat that thoat thanh cong.";
        public const string DELETE_THAT_THOAT_SUCCESS = "Xoa that thoat thanh cong.";
    }
    
    public class ReponseMessageConstantsChiSoDongHo
    {
        public const string CHI_SO_DONG_HO_NOT_FOUND = "Khong tim thay chi so dong ho.";
        public const string CHI_SO_DONG_HO_EXISTED = "Chi so dong ho da ton tai.";
        public const string UPDATE_CHI_SO_DONG_HO_SUCCESS = "Cap nhat chi so dong ho thanh cong.";
        public const string DELETE_CHI_SO_DONG_HO_SUCCESS = "Xoa chi so dong ho thanh cong.";
    }

    public class ReponseMessageConstantsSoDocChiSo
    {
        public const string SO_DOC_CHI_SO_NOT_FOUND = "Khong tim thay so doc chi so.";
        public const string SO_DOC_CHI_SO_EXISTED = "So doc chi so da ton tai.";
        public const string UPDATE_SO_DOC_CHI_SO_SUCCESS = "Cap nhat so doc chi so thanh cong.";
        public const string DELETE_SO_DOC_CHI_SO_SUCCESS = "Xoa so doc chi so thanh cong.";
        public const string NOT_EXISTED_NHAN_VIEN = "Khong co nhan vien trong tuyen nay";
        //public const string SO_DOC_CHI_SO_NOT_FOUND_TUYEN_DOC = "Nguoi quan ly khong quan ly tuyen doc nao.";
        //public const string TUYEN_DOC_NOT_FOUND_DONG_HO = "Tuyen doc khong chua dong ho nao.";
        public const string UNVALID_NGAYDAUKY_NGAYCUOIKY = "Ngay dau ky, ngay cuoi ky, ngay hoa don chua hop le.";
        public const string UNABLE_CHOTSO = "So doc nay chua duoc chot so";
        public const string UNABLE_KHOASO = "So doc cua dong ho block chua duoc khoa so";
        public const string UNABLE_KHOASO_OF_TONG = "So doc cua dong ho tong chua duoc khoa so";
        public const string UNABLE_KHOASO_OF_HODAN = "So doc cua dong ho ho dan chua duoc khoa so";
        public const string UNABLE_MOSO = "Khong the mo so nay";
        public const string NOT_FOUND_NGUOIQUANLY = "Khong tim thay nguoi quan ly";
    }

    public class ReponseMessageConstantsTrangThaiGhi
    {
        public const string TRANG_THAI_GHI_NOT_FOUND = "Khong tim thay trang thai ghi.";
        public const string TRANG_THAI_GHI_EXISTED = "Trang thai ghi da ton tai.";
        public const string UPDATE_TRANG_THAI_GHI_SUCCESS = "Cap nhat trang thai ghi thanh cong.";
        public const string DELETE_TRANG_THAI_GHI_SUCCESS = "Xoa trang thai ghi thanh cong.";
    }

    public class ReponseMessageConstantsKyGhiChiSo
    {
        public const string KY_GHI_CHI_SO_NOT_FOUND = "Khong tim thay ky ghi chi so.";
        public const string KY_GHI_CHI_SO_EXISTED = "Ky ghi chi so da ton tai.";
        public const string UPDATE_KY_GHI_CHI_SO_SUCCESS = "Cap nhat ky ghi chi so thanh cong.";
        public const string DELETE_KY_GHI_CHI_SO_SUCCESS = "Xoa ky ghi chi so thanh cong.";
    }

    public class ReponseMessageConstantsDanhMucSeriHoaDon
    {
        public const string DANH_MUC_SERI_HOA_DON_NOT_FOUND = "Khong tim thay danh muc seri.";
        public const string DANH_MUC_SERI_HOA_DON_EXISTED = "Danh muc seri da ton tai.";
        public const string UPDATE_DANH_MUC_SERI_HOA_DON_SUCCESS = "Cap nhat danh muc seri thanh cong.";
        public const string DELETE_DANH_MUC_SERI_HOA_DON_SUCCESS = "Xoa danh muc seri thanh cong.";
    }

    public class ReponseMessageConstantsPhienInThongBao
    {
        public const string PHIEN_IN_THONG_BAO_NOT_FOUND = "Khong tim thay phien in thong bao.";
        public const string PHIEN_IN_THONG_BAO_EXISTED = "Phien in thong bao da ton tai.";
        public const string UPDATE_PHIEN_IN_THONG_BAO_SUCCESS = "Cap nhat phien in thong bao thanh cong.";
        public const string DELETE_PHIEN_IN_THONG_BAO_SUCCESS = "Xoa phien in thong bao thanh cong.";
    }

    public class ReponseMessageConstantsHoaDon
    {
        public const string HOA_DON_CANNOT_CREATE = "Khong the tao hoa don";
        public const string HOA_DON_NOT_FOUND = "Khong tim thay hoa don.";
        public const string HOA_DON_EXISTED = "Hoa don da ton tai.";
        public const string SO_DOC_CHI_SO_TRANG_THAI_KHOA_SO = "So doc chi so phai duoc khoa truoc khi tao hoa don.";
        public const string HOP_DONG_NOT_FOUND = "Hop Dong khong ton tai.";
        public const string SERI_HOA_DON_NOT_FOUND = "Seri Hoa Don khong ton tai.";
        public const string SO_LUONG_HOA_DON_OF_SERI_HOA_DON_NOT_FOUND = "So luong hoa don cua seri hoa don da het.";
        public const string UPDATE_HOA_DON_SUCCESS = "Cap nhat hoa don thanh cong.";
        public const string DELETE_HOA_DON_SUCCESS = "Xoa hoa don thanh cong.";
    }

    public class ReponseMessageConstantsDanhMucThongBao
    {
        public const string DANH_MUC_THONG_BAO_NOT_FOUND = "Khong tim thay danh muc thong bao.";
        public const string DANH_MUC_THONG_BAO_EXISTED = "Danh muc thong bao da ton tai.";
        public const string UPDATE_DANH_MUC_THONG_BAO_SUCCESS = "Cap nhat danh muc thong bao thanh cong.";
        public const string DELETE_DANH_MUC_THONG_BAO_SUCCESS = "Xoa danh muc thong bao thanh cong.";
    }

    public class ReponseMessageConstantsThongBao
    {
        public const string THONG_BAO_NOT_FOUND = "Khong tim thay thong bao.";
        public const string THONG_BAO_EXISTED = "Dong bao da ton tai.";
        public const string UPDATE_THONG_BAO_SUCCESS = "Cap nhat thong bao thanh cong.";
        public const string DELETE_THONG_BAO_SUCCESS = "Xoa thong bao thanh cong.";
    }
    
    public class ReponseMessageConstantsDanhSachHoDan
    {
        public const string DANH_SACH_HO_DAN_NOT_FOUND = "Khong tim thay danh sach ho dan.";
        public const string DANH_SACH_HO_DAN_EXISTED = "Danh sach ho dan da ton tai.";
        public const string UPDATE_DANH_SACH_HO_DAN_SUCCESS = "Cap nhat danh sach ho dan thanh cong.";
        public const string DELETE_DANH_SACH_HO_DAN_SUCCESS = "Xoa danh sach ho dan thanh cong.";
    }

    public class ReponseMessageConstantsPhuongThucThanhToan
    {
        public const string PHUONG_THUC_THANH_TOAN_NOT_FOUND = "Khong tim thay phuong thuc thanh toan.";
        public const string PHUONG_THUC_THANH_TOAN_EXISTED = "Phuong thuc thanh toan da ton tai.";
        public const string UPDATE_PHUONG_THUC_THANH_TOAN_SUCCESS = "Cap nhat phuong thuc thanh toan thanh cong.";
        public const string DELETE_PHUONG_THUC_THANH_TOAN_SUCCESS = "Xoa phuong thuc thanh toan thanh cong.";
    }

    public class ReponseMessageConstantsMauTinSMS
    {
        public const string MAU_TIN_SMS_NOT_FOUND = "Khong tim thay mau tin sms.";
        public const string MAU_TIN_SMS_EXISTED = "Mau tin sms da ton tai.";
        public const string UPDATE_MAU_TIN_SMS_SUCCESS = "Cap nhat mau tin sms thanh cong.";
        public const string DELETE_MAU_TIN_SMS_SUCCESS = "Xoa mau tin sms thanh cong.";
    }

    public class ReponseMessageConstantsLichSuSMS
    {
        public const string LICH_SU_SMS_NOT_FOUND = "Khong tim thay lich su sms.";
        public const string LICH_SU_SMS_EXISTED = "Lich su sms da ton tai.";
        public const string UPDATE_LICH_SU_SMS_SUCCESS = "Cap nhat lich su sms thanh cong.";
        public const string DELETE_LICH_SU_SMS_SUCCESS = "Xoa lich su sms thanh cong.";
    }

    public class ReponseMessageConstantsNhatKyHoaDon
    {
        public const string NHAT_KY_HOA_DON_NOT_FOUND = "Khong tim thay nhat ky hoa don.";
        public const string NHAT_KY_HOA_DON_EXISTED = "Nhat ky hoa don da ton tai.";
        public const string UPDATE_NHAT_KY_HOA_DON_SUCCESS = "Cap nhat nhat ky hoa don thanh cong.";
        public const string DELETE_NHAT_KY_HOA_DON_SUCCESS = "Xoa nhat ky hoa don thanh cong.";
    }

    public class ReponseMessageConstantsChiTietHoaDon
    {
        public const string CHI_TIET_HOA_DON_NOT_FOUND = "Khong tim thay chi tiet hoa don.";
        public const string CHI_TIET_HOA_DON_EXISTED = "Chi tiet hoa don da ton tai.";
        public const string UPDATE_CHI_TIET_HOA_DON_SUCCESS = "Cap nhat chi tiet hoa don thanh cong.";
        public const string DELETE_CHI_TIET_HOA_DON_SUCCESS = "Xoa chi tiet hoa don thanh cong.";
    }

    public class ReponseMessageConstantsNguoiDung
    {
        public const string NGUOI_DUNG_NOT_FOUND = "Khong tim thay nguoi dung.";
        public const string NGUOI_DUNG_EXISTED = "Nguoi dung da ton tai.";
        public const string UPDATE_NGUOI_DUNG_SUCCESS = "Cap nhat nguoi dung thanh cong.";
        public const string DELETE_NGUOI_DUNG_SUCCESS = "Xoa nguoi dung thanh cong.";
    }

    public class ReponseMessageConstantsTinh
    {
        public const string TINH_NOT_FOUND = "Khong tim thay tinh.";
        public const string TINH_EXISTED = "Tinh da ton tai.";
        public const string UPDATE_TINH_SUCCESS = "Cap nhat tinh thanh cong.";
        public const string DELETE_TINH_SUCCESS = "Xoa tinh thanh cong.";
    }
    public class ReponseMessageConstantsHuyen
    {
        public const string HUYEN_NOT_FOUND = "Khong tim thay huyen.";
        public const string HUYEN_EXISTED = "Huyen da ton tai.";
        public const string UPDATE_HUYEN_SUCCESS = "Cap nhat huyen thanh cong.";
        public const string DELETE_HUYEN_SUCCESS = "Xoa huyen thanh cong.";
    }
    public class ReponseMessageConstantsXa
    {
        public const string XA_NOT_FOUND = "Khong tim thay xa.";
        public const string XA_EXISTED = "Xa da ton tai.";
        public const string UPDATE_XA_SUCCESS = "Cap nhat xa thanh cong.";
        public const string DELETE_XA_SUCCESS = "Xoa xa thanh cong.";
    }
    public class ReponseMessageConstantsPhamVi
    {
        public const string PHAMVI_NOT_FOUND = "Khong tim thay pham vi.";
        public const string PHAMVI_EXISTED = "Pham vi da ton tai.";
        public const string UPDATE_PHAMVI_SUCCESS = "Cap nhat pham vi thanh cong.";
        public const string DELETE_PHAMVI_SUCCESS = "Xoa pham vi thanh cong.";
    }
    public class ReponseMessageConstantsKieuDongHo
    {
        public const string KIEUDONGHO_NOT_FOUND = "Khong tim thay kieu dong ho.";
        public const string KIEUDONGHO_EXISTED = "Kieu dong ho da ton tai.";
        public const string UPDATE_KIEUDONGHO_SUCCESS = "Cap nhat kieu dong ho thanh cong.";
        public const string DELETE_KIEUDONGHO_SUCCESS = "Xoa kieu dong ho thanh cong.";
    }
    public class ReponseMessageConstantsNuocSanXuat
    {
        public const string NUOCSANXUAT_NOT_FOUND = "Khong tim thay nuoc san xuat.";
        public const string NUOCSANXUAT_EXISTED = "Nuoc san xuat da ton tai.";
        public const string UPDATE_NUOCSANXUAT_SUCCESS = "Cap nhat nuoc san xuat thanh cong.";
        public const string DELETE_NUOCSANXUAT_SUCCESS = "Xoa nuoc san xuat thanh cong.";
    }
    public class ReponseMessageConstantsHangSanXuat
    {
        public const string HANGSANXUAT_NOT_FOUND = "Khong tim thay hang san xuat.";
        public const string HANGSANXUAT_EXISTED = "Hang san xuat da ton tai.";
        public const string UPDATE_HANGSANXUAT_SUCCESS = "Cap nhat hang san xuat thanh cong.";
        public const string DELETE_HANGSANXUAT_SUCCESS = "Xoa hang san xuat thanh cong.";
    }
    public class ReponseMessageConstantsDanhMuc
    {
        public const string DANH_MUC_NOT_FOUND = "Khong tim thay danh muc.";
        public const string DANH_MUC_EXISTED = "Danh muc da ton tai.";
        public const string UPDATE_DANH_MUC_SUCCESS = "Cap nhat danh muc thanh cong.";
        public const string DELETE_DANH_MUC_SUCCESS = "Xoa danh muc thanh cong.";
        public const string REQUIRED_PARAM = "Mot so tham so truyen vao bi thieu, xin hay kiem tra lai.";
        public const string ACTION_NOT_FOUND = "action khong dung, hay kiem tra lai action.";
    }

    public class ReponseMessageConstantsTuyenOngNuoc
    {
        public const string NOT_FOUND = "Not Found.";
        public const string EXISTED = "Existed.";
        public const string SUCCESS = "Success.";
        public const string FAILED = "Failed.";
        public const string FAILMAP = "Failed to map model.";
    }

    public class ReponseMessageIdentity
    {
        public const string INVALID_USER = "Nguoi dung khong ton tai.";
        public const string UNAUTHENTICATED = "Khong xac thuc.";
        public const string PASSWORD_NOT_MATCH = "Mat khau khong giong nhau.";
        public const string PASSWORD_WRONG = "Mat khau khong dung.";
        public const string EXISTED_USER = "Nguoi dung da ton tai.";
        public const string EXISTED_EMAIL = "Email da ton tai.";
        public const string REGIST_USER_SUCCESS = "tao tai khoan thanh cong, vui long kiem tra email de xac thuc tai khoan.";
        public const string TOKEN_INVALID = "token khong xac thuc.";
        public const string TOKEN_INVALID_OR_EXPIRED = "token khong xac thuc hoac da het han.";
        public const string EMAIL_VALIDATE = "Email da duoc xav thuc.";
        public const string ROLE_INVALID = "Roles khong xac thuc.";
        public const string CLAIM_NOTFOUND = "Khong tim thay claim.";
        public const string EXISTED_ROLE = "Role da ton tai.";

        public const string USERNAME_REQUIRED = "Ten nguoi dung khong duoc de trong.";
        public const string NAME_REQUIRED = "Ten khong duoc de trong.";
        public const string USERCODE_REQUIRED = "Ma nguoi dung khong duoc de trong.";
        public const string PASSWORD_REQUIRED = "Mat khau khong duoc de trong.";
        public const string CONFIRM_PASSWORD_REQUIRED = "Xac nhan mat khau khong duoc de trong.";
        public const string EMAIL_REQUIRED = "Email khong duoc de trong.";
        public const string PHONENUMBER_REQUIRED = "So dien thoai khong duoc de trong.";
        public const string PHONENUMBER_INVALID = "So dien thoai khong hop le.";
        public const string PHONENUMBER_LENGTH = "So dien thoai phai co chinh xac 10 so.";
        public const string PHONGBANID_REQUIRED = "Phong ban khong duoc de trong.";
        public const string NHAMAYIDS_REQUIRED = "Nha may khong duoc de trong.";
        public const string ROLEIDS_REQUIRED = "Role khong duoc de trong.";

    }
    public class ResponseMessageConstantsSoDoMapTuyen
    {
        public const string NOT_FOUND = "Khong tim thay so do map";
        public const string EXISTED = "Existed.";
        public const string ADD_SUCCESS = "Them so do tuyen thanh cong";
        public const string UPDATE_SUCCESS = "Cap nhat so do thanh cong";
        public const string DELETE_SUCCESS = "Xoa map tuyen thanh cong";
    }
    public class ResponseMessageConstantsSoDoMapNhaMay
    {
        public const string NOT_FOUND = "Khong tim thay so do map nha map";
        public const string EXISTED = "Existed.";
        public const string ADD_SUCCESS = "Them so do nha may thanh cong";
        public const string UPDATE_SUCCESS = "Cap nhat so do nha may thanh cong";
        public const string DELETE_SUCCESS = "Xoa map nha may thanh cong";

    }

    public class ResponseMessageConstantsPhongBan
    {
        public const string NOT_FOUND = "Khong tim thay Phong ban.";
        public const string EXISTED = "Existed.";
        public const string ADD_SUCCESS = "Them phong ban thanh cong.";
        public const string UPDATE_SUCCESS = "Cap nhat phong ban thanh cong";
        public const string DELETE_SUCCESS = "Xoa phong ban thanh cong";
    }
    public class PhuongThucThanhToanConstant
    {
        public const string PHUONG_THUC_THANH_TOAN_MAC_DINH_KEY_ID = "TMat";
    }
}
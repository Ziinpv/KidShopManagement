# KidStoreManagement

## Mô tả
KidStoreManagement là một ứng dụng quản lý cửa hàng bán quần áo trẻ em CƠ BẢN được thực hiện nhằm đáp ứng yêu cầu môn học Lập trình ứng dụng Desktop, cho phép quản lý danh sách quần áo, hóa đơn, khách hàng, nhân viên, và doanh thu.

## Tính năng
- **Quản lý quần áo:** Thêm, sửa, xóa và tìm kiếm quần áo trong kho hàng.
- **Quản lý hóa đơn:** Tạo hóa đơn cho khách hàng và theo dõi doanh thu.
- **Quản lý khách hàng:** Tạo, quản lý và chỉnh sửa thông tin khách hàng.
- **Quản lý nhân viên:** Quản lý thông tin và theo dõi hoạt động của nhân viên.
- **Thống kê và báo cáo:** Thống kê doanh thu theo nhân viên, hóa đơn, và theo thời gian.
- **Biểu đồ trực quan:** Hiển thị biểu đồ doanh thu và các sản phẩm bán chạy.

## Công nghệ sử dụng
- .NET Framework, ADO.NET
- Guna.UI2.WinForms
- SQL Server

## Yêu cầu hệ thống
- **.NET Framework:** 4.8

## Hướng dẫn cài đặt

### 1. Clone Repository
```bash
git clone https://github.com/Ziinpv/KidShopManagement
cd KidShopManagement
```

### 2. Mở Solution với Visual Studio
- Mở file `KidStoreManagement.sln` bằng Visual Studio.

### 3. Cài đặt các Package cần thiết
sử dụng **NuGet Package Manager** để cài đặt các package thiếu.
``
Update-Database
``

### 4. Cấu hình chuỗi kết nối
Chỉnh sửa file `App.config` trong dự án `KidStoreManagement` để cấu hình chuỗi kết nối đến SQL Server.
```xml
<connectionStrings>
	<add name="RestaurantContext"
	connectionString="Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;Trust Server Certificate=True;"
	providerName="System.Data.SqlClient"/>
</connectionStrings>
```

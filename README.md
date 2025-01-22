# Exercise 1 (World Database)

## Bài tập yêu cầu

### **Mô tả**
Tạo một ứng dụng để khám phá cơ sở dữ liệu **World Database** theo các yêu cầu sau:

### **Phía Server**
Sử dụng SOAP Services để cung cấp các chức năng:
1. Lấy danh sách tất cả các quốc gia từ cơ sở dữ liệu.
2. Lấy thông tin quốc gia dựa trên mã quốc gia (country code).
3. Tìm kiếm thành phố theo tên.
4. Lấy danh sách tất cả các thành phố của một quốc gia cụ thể dựa trên mã quốc gia.
5. Lấy danh sách các quốc gia thuộc một châu lục cụ thể.
6. Tìm kiếm các thành phố theo dân số.

### **Phía Client**
- Tạo một ứng dụng Windows Form để gọi và hiển thị dữ liệu từ các dịch vụ SOAP đã triển khai trên phía server.

---

## **Kết quả đạt được**

### **1. Kết nối cơ sở dữ liệu và kiểm tra kết nối**
Kết nối thành công với cơ sở dữ liệu và thực hiện kiểm tra kết nối. Dữ liệu được truy xuất thành công và đảm bảo tính chính xác.

---

### **2. Chạy dịch vụ Web (WebService)**
SOAP Services đã được triển khai thành công trên server. Tất cả các phương thức API hoạt động đúng như mong đợi và phản hồi nhanh chóng.

---

### **3. Giao diện phía Client**
Ứng dụng Windows Form được xây dựng hoàn chỉnh để gọi các dịch vụ SOAP từ phía server. Giao diện đơn giản, dễ sử dụng và hiển thị chính xác dữ liệu từ các dịch vụ.

---

### **4. Các chức năng chính**

#### **4.1. Lấy danh sách tất cả các quốc gia**
- Lấy và hiển thị danh sách tất cả các quốc gia trong cơ sở dữ liệu. Chức năng này hoạt động ổn định và trả về đầy đủ dữ liệu.

---

#### **4.2. Lấy thông tin quốc gia theo mã quốc gia**
- Tìm kiếm và lấy thông tin chi tiết của một quốc gia dựa trên mã quốc gia (country code). Thông tin được trả về chính xác dựa trên mã nhập vào.

---

#### **4.3. Tìm kiếm thành phố theo tên**
- Tìm kiếm và hiển thị thông tin chi tiết của một thành phố dựa trên tên thành phố. Chức năng tìm kiếm hoạt động nhanh và chính xác.

---

#### **4.4. Lấy danh sách các thành phố của một quốc gia**
- Hiển thị danh sách tất cả các thành phố thuộc một quốc gia cụ thể dựa trên mã quốc gia. Chức năng này đảm bảo trả về danh sách đầy đủ và đúng thứ tự.

---

#### **4.5. Lấy danh sách các quốc gia thuộc một châu lục**
- Hiển thị danh sách các quốc gia thuộc một châu lục cụ thể. Chức năng này hỗ trợ lọc theo châu lục và hoạt động đúng yêu cầu.

---

#### **4.6. Tìm kiếm các thành phố theo dân số**
- Hiển thị danh sách các thành phố dựa trên số lượng dân cư. Kết quả tìm kiếm chính xác và hỗ trợ tốt việc lọc dữ liệu theo dân số.

---

## **Kết luận**
### Những gì đã hoàn thành:
- Tạo thành công SOAP Services để truy xuất dữ liệu từ cơ sở dữ liệu.
- Xây dựng ứng dụng Windows Form để gọi và hiển thị các kết quả từ dịch vụ.
- Thực hiện đầy đủ các chức năng CRUD trên cơ sở dữ liệu.
- Đảm bảo dữ liệu được hiển thị đúng và giao diện thân thiện với người dùng.

## 🛣 **ROADMAP HỌC ORCHARD CORE CHI TIẾT**  
> ⏳ **Thời gian đề xuất:** ~4-8 tuần (tùy tốc độ học)  
> 🔹 **Yêu cầu nền tảng:** C# + ASP.NET Core + Entity Framework + Razor  

### 📌 **Giai đoạn 1: Hiểu Tổng Quan Về Orchard Core** (Tuần 1)  
✅ **Tìm hiểu khái niệm cơ bản:**  
   - Orchard Core là gì? So sánh với WordPress, Umbraco.  
   - Kiến trúc Modular, Multi-Tenancy, Headless CMS.  
   - Cách hoạt động của Themes, Modules, Content Types.  

✅ **Cài đặt và chạy thử:**  
   - Cài đặt Orchard Core bằng `dotnet new orchardcms`.  
   - Chạy dự án, truy cập giao diện admin `/admin`.  
   - Tạo trang web đầu tiên, thêm nội dung, quản lý users.  

📌 **Mục tiêu:** Biết cách khởi chạy và thao tác cơ bản với Orchard Core CMS.  

---

### 📌 **Giai đoạn 2: Làm Quen Với Kiến Trúc & Thành Phần Chính** (Tuần 2-3)  
✅ **Hiểu kiến trúc dự án**  
   - `OrchardCore.Cms.Web` và cách tổ chức thư mục.  
   - **Modules**: Cách hoạt động, cách bật/tắt module.  
   - **Themes**: Cấu trúc themes, cách tạo theme mới.  
   - **Content Management**: Pages, Content Types, Fields, Parts.  

✅ **Tùy chỉnh giao diện với Razor/Liquid**  
   - Tạo **Theme** bằng Razor & Liquid Template.  
   - Cấu hình Layout.cshtml để tạo giao diện riêng.  

📌 **Mục tiêu:** Hiểu cách tổ chức dự án và biết cách custom giao diện.  

---

### 📌 **Giai đoạn 3: Phát Triển Module Riêng** (Tuần 4-5)  
✅ **Tạo module mới** 🛠  
   - Cấu trúc **OrchardCore.Module**.  
   - Tạo **Custom Content Type** và hiển thị trên UI.  
   - Đăng ký module vào Orchard Core.  

✅ **Làm việc với Database**  
   - Tích hợp **Entity Framework Core** với Orchard Core.  
   - Tạo **Migration** cho bảng trong module riêng.  
   - Tương tác với DB bằng **ContentManager API**.  

📌 **Mục tiêu:** Biết cách tạo module riêng và lưu dữ liệu vào DB.  

---

### 📌 **Giai đoạn 4: Xây Dựng API & Headless CMS** (Tuần 6)  
✅ **Kích hoạt REST API**  
   - Bật module `OrchardCore.RestApis`.  
   - Tạo API để lấy danh sách bài viết.  
   - Truy vấn dữ liệu từ frontend Angular/React.  

✅ **Tích hợp GraphQL**  
   - Bật module `OrchardCore.GraphQL`.  
   - Viết query GraphQL để lấy dữ liệu content.  

📌 **Mục tiêu:** Biết cách dùng Orchard Core làm **Headless CMS**.  

---

### 📌 **Giai đoạn 5: Multi-Tenancy & Bảo Mật** (Tuần 7)  
✅ **Multi-Tenant trong Orchard Core**  
   - Cách tạo **nhiều website trên 1 instance**.  
   - Cấu hình **tenant riêng biệt** cho mỗi khách hàng.  

✅ **Bảo mật & Authentication**  
   - Cấu hình **Identity & OAuth**.  
   - Đăng nhập, phân quyền theo **Role & Permission**.  

📌 **Mục tiêu:** Biết cách triển khai nhiều website trên 1 hệ thống và bảo mật.  

---

### 📌 **Giai đoạn 6: Triển Khai Thực Tế** (Tuần 8)  
✅ **Triển khai trên server (Docker, Azure, AWS)**  
   - Deploy bằng **Docker + Kubernetes**.  
   - Cấu hình **CI/CD với GitHub Actions**.  

✅ **Tối ưu & mở rộng**  
   - Cấu hình Cache với Redis.  
   - Tối ưu hiệu suất bằng Lazy Loading.  

📌 **Mục tiêu:** Biết cách deploy dự án **Orchard Core** lên production.  

---

## 🎯 **Tóm Tắt Roadmap Học Orchard Core**  
✅ **Tuần 1:** Hiểu tổng quan, cài đặt & làm quen với CMS.  
✅ **Tuần 2-3:** Hiểu kiến trúc, làm việc với Themes, Content Types.  
✅ **Tuần 4-5:** Viết module riêng, làm việc với database.  
✅ **Tuần 6:** Xây dựng API & dùng như Headless CMS.  
✅ **Tuần 7:** Multi-Tenant, bảo mật, authentication.  
✅ **Tuần 8:** Triển khai thực tế, tối ưu hệ thống.  

## Nghiên cứu Orchard Core phụ vụ cho dự án 
🎯 Mục tiêu cuối cùng:
   ✅ Lập trình viên có thể tùy biến Orchard Core để:
      Tạo module riêng
      Tạo content type tùy biến
      Tích hợp giao diện
      Giao tiếp với các hệ thống bên ngoài qua API

🧭 Lộ trình 5 giai đoạn:
   1. Tổng quan & Cài đặt thử nghiệm (1–2 ngày)
      Hiểu khái niệm Orchard Core là gì, so với WordPress, Umbraco, v.v.
      Tải mã nguồn và cài đặt bản demo từ https://orchardcore.net/
      Cài đặt mẫu CMS với SQLite/SQL Server, tạo site mẫu

      🛠 Kết quả cần đạt:
         Chạy thử được Orchard Core CMS
         Tạo content type và content item đơn giản trong giao diện admin

   2. Kiến trúc & Thành phần chính (2–4 ngày)
      Orchard Core MVC & Modular Architecture
      Content Type, Content Part, Content Field
      Tenant, Deployment Plan, Recipe
      Layer, Widget, Liquid Template

      🛠 Kết quả cần đạt:
         Hiểu được mỗi phần đóng vai trò gì
         Có thể mở rộng Content Type/Field không cần code

   3. Tùy biến qua giao diện & Theme (3–5 ngày)
      Cách tạo Theme riêng (dựa trên TheAgency hoặc SafeMode)
      Sử dụng Razor/Liquid
      Sử dụng Zone/Shape để cấu trúc trang
      🛠 Kết quả cần đạt:
         Tạo được Theme riêng
         Giao diện tùy biến hiển thị Content Items như mong muốn

   4. Viết Module mới (5–7 ngày)
      Cách tạo một Module Orchard Core
      Đăng ký dịch vụ qua Dependency Injection
      Giao diện Admin, xử lý dữ liệu
      Tạo ContentPart/ContentField bằng code
      Tích hợp REST API, Background Task

      🛠 Kết quả cần đạt:
         Tạo được một module mới (VD: Booking, Library Item, ...)
         Có thể giao tiếp với hệ thống khác (Web API, file, v.v.)

   5. Nâng cao & Tùy biến sâu (tùy dự án)
      Viết Custom Display Drivers
      Tích hợp với Authentication ngoài (OAuth2, LDAP, ...)
      Viết Recipe cài đặt nhanh
      Gói lại thành package tái sử dụng

---

## Set up OrchardCore CMS
   Cách 1:
      dotnet new occms -n startoccms

   Cách 2:
      dotnet tool install -g OrchardCore.CodeGeneration.CLI
      Init-OrchardCoreSolution -Name "DojoCourse" -ModuleName "Booking.Module" -ThemeName "Booking.Theme"


## Tổng quan về ContentType, ContentPart, ContentField, ContentItem
   Khái niệm	         Vai trò tương đương
   ContentType	      Một loại nội dung – giống như một class
   ContentPart	      Một khối dữ liệu có thể dùng chung giữa nhiều ContentType
   ContentField	   Một trường dữ liệu cụ thể như Text, Date, Boolean...
   Content Item	   Một bản ghi cụ thể được tạo từ ContentType – giống như new object()
   Sơ đồ:
      ContentType: Kiểu nội dung trong OC
         -> ContentPart: Khối dữ liệu có thể tái sử dụng
            -> ContentField: Text, Date, Boolean, ....
      ContentItem là bản ghi cụ thể được tạo từ ContentType
   
   ContentType: Booking
      └── ContentPart: BookingPart
            ├── ContentField: BookingDate (DateTimeField)
            ├── ContentField: CustomerName (TextField)
            └── ContentField: IsPaid (BooleanField)
   
   ✅ Ý hiểu của bạn (rất chuẩn):
      Thành phần	               Vai trò & Ý nghĩa
      ContentType	               Định nghĩa một loại nội dung cụ thể (ví dụ: Booking, BlogPost). Nó giống như một model tổng thể chứa nhiều phần.
      ContentPart	               Một phần trong ContentType – chứa nhiều ContentField. Có thể tái sử dụng giữa nhiều ContentType (modular & DRY).
      ContentField	            Trường dữ liệu nhỏ như Text, Boolean, DateTime… được gán vào ContentPart để xây nên UI đầu cuối.
      🔍 Một ví dụ thực tế hơn:
         Nếu bạn định nghĩa một loại nội dung tên LibraryBook:
            ContentType: LibraryBook
               ContentPart: LibraryMetadataPart
                  Title (TextField)
                  Author (TextField)
                  PublishedDate (DateTimeField)
         ContentPart: LibraryStatusPart
            IsAvailable (BooleanField)
            Location (TextField)

         => Bạn có thể dùng LibraryMetadataPart cho các ContentType khác như Magazine, Newspaper...


## ContentType
   🧱 Tư duy: ContentType giống như class trong lập trình
   🧠 Hiểu đúng về ContentType trong Orchard Core
      Trong Orchard Core, mọi thứ đều là “Content Item”, và ContentType là “định nghĩa” của một loại Content Item.

   🧩 Ví dụ để dễ hiểu:
      Giả sử bạn xây dựng một hệ thống quản lý thư viện:

         Bạn cần lưu cái gì?	              Đó chính là một ContentType
         Sách (Book)	                        ContentType tên Book
         Người dùng (UserProfile)	         ContentType tên UserProfile
         Lịch đặt phòng (Booking)	         ContentType tên Booking
         Tin tức  (News)	                  ContentType tên NewsArticle
      
      Mỗi ContentType có thể được tạo bằng cách lắp các ContentPart, mỗi Part có thể chứa nhiều Field (kiểu dữ liệu cụ thể như Text, Date, Boolean...).

## ContentPart
   ContentPart là một khối dữ liệu (hoặc logic) có thể được gắn vào một ContentType, và có thể tái sử dụng ở nhiều nơi.
   🔧 Có 2 loại ContentPart:
      Loại	                           Mô tả
      Reusable ContentPart	         Tạo 1 lần, gắn nhiều nơi. (Giống như ví dụ CommonMetadataPart)
      Inline ContentPart	         Tạo riêng cho 1 ContentType, không dùng lại chỗ khác.
   
   🧠 Ví dụ dễ hiểu:
      Giả sử bạn có 3 ContentType:
         Book
         NewsArticle
         Course

      Cả 3 đều cần mô tả nội dung bằng đoạn text có tiêu đề, mô tả ngắn, và nội dung chi tiết.
      Thay vì lặp đi lặp lại các ContentField giống nhau cho từng loại ContentType, bạn tạo 1 ContentPart tên là CommonMetadataPart gồm:
         Title (TextField)
         Summary (TextField)
         Body (HtmlField)

      → Giờ bạn chỉ cần gắn CommonMetadataPart vào các ContentType cần thiết.

   🛠 Công dụng của ContentPart
      Công dụng	                        Mô tả
      ♻️ Tái sử dụng	                  Dễ dàng chia sẻ giữa nhiều ContentType.
      🧩 Tách biệt logic	            Có thể viết mã riêng xử lý cho Part, như Display Driver, Handler, v.v.
      ⚙️ Tự động mở rộng	            Bạn có thể thêm Field vào Part bất kỳ lúc nào mà không ảnh hưởng đến các ContentType khác.
      🔍 Dễ kiểm soát hiển thị         Mỗi Part có thể có logic riêng để hiển thị trong admin / frontend.

## ContentField
   ✅ ContentField là gì?
      ContentField là những trường dữ liệu nhỏ gọn, cụ thể mà bạn thêm vào trong 1 ContentPart.
   Ví dụ:
      Bạn có một ContentPart như BookingPart:
         public class BookingPart : ContentPart
         {
            public DateTime BookingDate { get; set; }
            public string CustomerName { get; set; }
         }

      Thì tương ứng trong Orchard Core, bạn có thể định nghĩa BookingPart như sau bằng cách dùng các ContentField:
         _contentDefinitionManager.AlterPartDefinition("BookingPart", part => part
            .WithField("BookingDate", f => f
               .OfType("DateTimeField")
               .WithDisplayName("Booking Date"))
            .WithField("CustomerName", f => f
               .OfType("TextField")
               .WithDisplayName("Customer Name"))
         );

## Module
   Cài đặt: 
      dotnet new ocmodulecms -n BookingTour.Module
   📦 1. Module là gì?
      Module là thành phần logic, là nơi chứa các chức năng, tính năng của website.

   🔧 Module có thể bao gồm:
      Thành phần	                        Ý nghĩa
      ContentPart / ContentType	         Định nghĩa nội dung
      DisplayDriver	                     Điều khiển hiển thị
      API Controller	                     Tạo các Web API
      Routes / Menu / Permissions	      Cấu hình admin UI
      Migration	                        Tạo bảng, seed dữ liệu
      Service / DI	                     Logic xử lý nghiệp vụ
   👉 Mỗi module có thể có nhiều Feature như bạn thấy trong ảnh lúc nãy, để bật/tắt từng phần tính năng.

## Widget and Zone
   ✅ 1. Widget là gì?
      Widget là một Content Item đặc biệt có thể được "cắm" vào các vùng cụ thể (Zone) trên giao diện — như là một khối nội dung (block).
   📌 Ví dụ:
      Một widget có thể là:
         Banner
         Slider
         Form đăng ký
         HTML tùy chỉnh
         Danh sách bài viết nổi bật
         Menu phụ
   Widgets thường là những khối nhỏ, được hiển thị ở nhiều vị trí khác nhau, không phải là nội dung chính.

   📦 2. Zone là gì?
      Zone là các khu vực định nghĩa sẵn trong Layout (giao diện).
      Bạn có thể hiểu Zone là "ô cắm Widget" trong một bố cục.
      🧱 Ví dụ thường gặp:
         Header
         Footer
         Sidebar
         BeforeMain
         AfterMain

   🧠 Một ví dụ dễ hiểu
      Giả sử bạn làm website Booking Tour, giao diện có:
         Thanh menu (Zone: Header)
         Form đăng ký nhanh (Zone: Sidebar)
         Chân trang (Zone: Footer)

      ➡️ Bạn tạo 3 Widget:
         Widget A: HTML cho menu
         Widget B: HTML cho form
         Widget C: Đoạn văn giới thiệu công ty
      Gắn A vào Header, B vào Sidebar, C vào Footer.

      ✨ Bonus: Cách tạo Widget mới
         Bật tính năng Widgets (nếu chưa bật)
         Vào Content → Content Types, tạo một loại Widget mới (ví dụ: "Banner Widget")
         Chọn loại là "Widget"
         Gán các ContentField cần thiết (title, image, body,...)
         Tạo một Content Item dạng Widget, chọn zone, lưu
         Đảm bảo layout của bạn có khai báo @RenderZoneAsync("TênZone")

## Workflow 
   Workflow trong Orchard Core là một công cụ mạnh mẽ cho phép bạn tự động hóa các tác vụ hoặc xử lý logic nghiệp vụ mà không cần viết code nhiều. Bạn có thể hình dung nó như kiểu "kịch bản luồng công việc" chạy tự động khi có sự kiện xảy ra trong hệ thống.

   🎯 Workflow dùng để làm gì?
      Trường hợp sử dụng	               Mô tả
      ✅ Gửi email tự động	         Gửi email xác nhận khi người dùng đặt tour, đăng ký tài khoản, hoặc gửi liên hệ.
      ✅ Tạo logic phê duyệt	      Ví dụ: khi người dùng tạo bài viết → gửi admin phê duyệt → sau đó mới đăng.
      ✅ Xử lý dữ liệu	            Khi một form được submit, bạn có thể lưu dữ liệu vào content item hoặc gọi API.
      ✅ Tự động tạo content	      Tự tạo một content item mới khi điều kiện nào đó xảy ra.
      ✅ Kết nối các hệ thống	      Gọi API hoặc gửi dữ liệu sang hệ thống khác khi có sự kiện.
      ✅ Gửi thông báo	            Tự động thông báo qua email, Slack, SMS...

   ⚙️ Workflow hoạt động như thế nào?
      1. Trigger – Điểm khởi động:
         Ví dụ: Khi người dùng submit form, khi bài viết được xuất bản, khi content bị xóa...

      2. Activities – Các bước xử lý:
         Gồm nhiều loại như:
            Gửi email
            Chạy mã Liquid
            Điều kiện rẽ nhánh
            Chờ đợi (delay)
            Gọi HTTP API
            Tạo hoặc chỉnh sửa content item...

      3. Kết thúc – Khi workflow hoàn tất hoặc bị dừng.

   👀 Ví dụ thực tế:
      Đặt tour thành công → Gửi email xác nhận
         Trigger: Content Published (TourBooking)
         Activity 1: Gửi Email cho khách (EmailTask)
         Activity 2: Gửi Email cho Admin (EmailTask)
         Activity 3: Cập nhật trạng thái booking

   ### Chú ý khi dùng Form với Workflow
      Anti Forgery Token (hay còn gọi là CSRF Token) là một cơ chế bảo mật dùng để ngăn chặn các cuộc tấn công CSRF (Cross-Site Request Forgery) – tức là giả mạo hành động của người dùng đã đăng nhập trên một website.

      🚨 Vấn đề đặt ra nếu không có Anti Forgery Token:
         Giả sử:
            Bạn đang đăng nhập vào trang quản trị (ví dụ admin.mysite.com)
            Bạn không thoát ra, rồi truy cập vào một trang độc hại (giả sử là evil.com)
            Trang đó chứa 1 đoạn mã gửi request POST đến admin.mysite.com/delete-all
         ➡️ Nếu không có cơ chế kiểm tra, server sẽ tưởng bạn đang thực sự gửi yêu cầu, và thực hiện hành động (xóa dữ liệu, đổi mật khẩu, v.v.)

      ✅ Cách hoạt động của Anti Forgery Token:
         Khi website render form, nó sinh ra một token ngẫu nhiên, chỉ có user đang mở session đó mới có:
         <input type="hidden" name="__RequestVerificationToken" value="abc123xyz456" />
         Khi form được submit, token này sẽ được gửi kèm.
         Ở server, hệ thống sẽ:
            Kiểm tra token có khớp với session hay không
            Nếu đúng, yêu cầu được chấp nhận
            Nếu sai hoặc không có, từ chối request → chặn tấn công CSRF

      🧩 Trong Orchard Core
         Khi bạn tick Anti Forgery Token trong form:
         Orchard sẽ tự động thêm token ẩn vào form.
         Và khi bạn xử lý qua controller hoặc workflow, bạn có thể kích hoạt việc kiểm tra token.

      ❓ Khi nào nên dùng?
         ✅ Bắt buộc dùng khi form thực hiện hành động thay đổi dữ liệu (POST/PUT/DELETE)
         ❌ Có thể bỏ qua nếu form chỉ hiển thị hoặc test nội bộ (hoặc xử lý qua Workflow không cần xác thực)

## Audit Trail 
   🔧 Audit Trail ghi lại những gì?
      Thay đổi nội dung (Create, Update, Delete)
      Đăng nhập / Đăng xuất
      Cập nhật user, role, permission
      Cài đặt/bật module, theme
      Các luồng công việc (Workflow)
      Và nhiều hành động khác tùy theo module được kích hoạt

   🛠️ Cách sử dụng trong Orchard Core
      Bật module Audit Trail trong admin
      Sau khi bật, mục Audit Trail sẽ xuất hiện trong menu admin
      Vào đó bạn sẽ thấy danh sách log:
      Mỗi dòng = 1 hành động
      Bao gồm: loại sự kiện, người thực hiện, thời gian, mô tả

## Multi-tenancy
   Xây dựng một Orchard Core SaaS với Multi-Tenancy (đa tenant) là một trong những tính năng mạnh mẽ nhất của Orchard Core. Đây là cách bạn có thể dùng một ứng dụng Orchard Core duy nhất để phục vụ nhiều khách hàng khác nhau (tenant), mỗi người có site riêng, cấu hình riêng, nội dung riêng – tất cả được chạy trong cùng một ứng dụng.
   🧠 1. Multi-Tenancy là gì?
      Multi-Tenancy nghĩa là một ứng dụng duy nhất phục vụ nhiều "tenant" khác nhau, ví dụ:
      Mỗi tenant là một công ty khác nhau.
      Mỗi tenant có:
         Tên miền riêng (subdomain: a.mysaas.com, b.mysaas.com)
         Giao diện riêng.
         Nội dung riêng.
         Người dùng riêng.
         Thậm chí cả database riêng nếu cấu hình như vậy.
      Nó giống như việc bạn tạo một hệ thống tạo website cá nhân/hệ thống quản trị nội dung riêng cho từng người nhưng tất cả dùng cùng một app chạy phía server.
   
   🎯 2. Tác dụng của Multi-Tenancy
      Tác dụng	                     Mô tả
      ✅ Tối ưu chi phí	         Chạy một ứng dụng thay vì deploy nhiều ứng dụng cho từng khách hàng.
      ✅ Quản lý tập trung	      Tất cả tenants được quản lý trong một nơi duy nhất (host tenant).
      ✅ Dễ scale	               Chia tenant ra theo nhu cầu, có thể scale theo database, subdomain, hoặc server.
      ✅ Tùy biến cao            	Mỗi tenant có thể có cấu hình, theme, module khác nhau.
   
   📌 3. Áp dụng khi nào?
      Bạn nên dùng Multi-Tenancy khi:
         Bạn đang xây dựng một hệ thống kiểu SaaS (Software-as-a-Service).
         Bạn muốn mỗi khách hàng có website riêng.
         Bạn không muốn viết lại cùng một ứng dụng nhiều lần.
         Bạn cần phân tách dữ liệu giữa các khách hàng.

   🛠️ 4. Làm như thế nào trong Orchard Core?
      Bước 1: Kích hoạt Multi-Tenancy
         Vào Configuration > Features của Orchard Core.
         Tìm và bật tính năng Tenants.

      Bước 2: Tạo Tenant mới
         Vào Configuration > Tenants.
         Nhấn Create Tenant.
         Điền các thông tin:
            Name: tên hệ thống dùng để quản lý.
            URL Prefix hoặc Hostname: để phân biệt giữa các tenant (vd: /tenant1, tenant1.mysite.com)
            Recipe: chọn công thức setup ban đầu (Blank, Blog, Agency, etc.)
            Database: có thể dùng cùng 1 SQLite/SQL Server hoặc tách riêng.

      Bước 3: Truy cập và cài đặt tenant
         Sau khi tạo xong, click vào Setup link của tenant để cài đặt như một Orchard Core mới: tạo user admin, site name, v.v.
         Tenant sẽ chạy hoàn toàn tách biệt với các tenant khác, dù dùng cùng một codebase.

## Tự tạo một theme riêng bằng code
   B1:
      dotnet new -i OrchardCore.ProjectTemplates::*
      - Chú ý phải cùng phiên bản với root sln dự án
      Dòng này sẽ cài các template của Orchard Core như CMS Website, Module, Theme, ... 
   B2: 
      Tạo folder MyTheme.OrchardCore rồi chạy lệnh
      dotnet new octheme -n "ThemeName.OrchardCore"
      Lệnh này sẽ tạo thư mục MyCustomTheme chứa các file cần thiết như Manifest.cs, Views/Layout.liquid, Assets, v.v.
   B3:
      Add file MyTheme.OrchardCore.csproj vào project sln của root project 
   B4: 
      Rebuild and check theme đã hiển thị trong Theme chưa
   
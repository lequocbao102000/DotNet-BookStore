
USE [QL_NHASACH2]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 5/21/2021 10:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[mahd] [int] NOT NULL,
	[masach] [int] NOT NULL,
	[soluong] [int] NULL,
	[thanhtien] [int] NULL,
 CONSTRAINT [pk_5] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUDE]    Script Date: 5/21/2021 10:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUDE](
	[macd] [int] IDENTITY(1,1) NOT NULL,
	[tencd] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[macd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 5/21/2021 10:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[mahd] [int] NOT NULL,
	[nguoiban] [char](30) NULL,
	[khachmua] [char](12) NULL,
	[ngaymua] [char](50) NULL,
	[tongtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 5/21/2021 10:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[manxb] [int] IDENTITY(1,1) NOT NULL,
	[tennxb] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[manxb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 5/21/2021 10:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[masach] [int] NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[gia] [int] NULL,
	[soluong] [int] NULL,
	[mota] [nvarchar](max) NULL,
	[macd] [int] NULL,
	[manxb] [int] NULL,
	[matg] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 5/21/2021 10:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[matg] [int] IDENTITY(1,1) NOT NULL,
	[tentg] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[matg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 5/21/2021 10:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[tentk] [char](30) NOT NULL,
	[matkhau] [char](30) NULL,
	[hoten] [nvarchar](50) NULL,
	[chucvu] [nvarchar](20) NULL,
	[gioitinh] [nvarchar](3) NULL,
	[ngaysinh] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[tentk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CHUDE] ON 

INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (1, N'Văn học')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (2, N'Huyền bí giả tưởng')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (3, N'Kinh điển')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (4, N'Trinh thám')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (5, N'Tản văn')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (6, N'Tiểu sử')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (7, N'Âm nhạc')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (8, N'Tâm linh')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (9, N'Khoa học')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (10, N'Kỹ năng làm việc')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (11, N'Tài chính')
INSERT [dbo].[CHUDE] ([macd], [tencd]) VALUES (12, N'Du ký')
SET IDENTITY_INSERT [dbo].[CHUDE] OFF
GO
INSERT [dbo].[HOADON] ([mahd], [nguoiban], [khachmua], [ngaymua], [tongtien]) VALUES (1, N'baole1010                     ', N'070345662   ', N'01/01/2020                                        ', 20000)
GO
SET IDENTITY_INSERT [dbo].[NHAXUATBAN] ON 

INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (1, N'NXB Kim Đồng')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (2, N'NXB Trẻ')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (3, N'NXB Tổng hợp TpHCM')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (4, N'NXB Chính trị quốc gia sự thật')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (5, N'NXB Giáo dục')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (6, N'NXB Hội nhà văn')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (7, N'NXB Tư pháp')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (8, N'NXB Thông tin và Truyền thông')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (9, N'NXB Lao động')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (10, N'NXB Giao thông vận tải')
INSERT [dbo].[NHAXUATBAN] ([manxb], [tennxb]) VALUES (11, N'NXB ĐH quốc gia Hà Nội')
SET IDENTITY_INSERT [dbo].[NHAXUATBAN] OFF
GO
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (1, N'Những Người Khốn Khổ', 130000, 100, N'Trong tác phẩm Những Người Khốn Khổ, cuộc sống cao đẹp của Giăngvăngiăng – người phải ngồi tù suốt 19 năm chỉ vì một chiếc bánh mỳ, tình nhân ái bao dung và tấm lòng độ lượng của đức cha Mirien, sự đeo bám dai dẳng của mật thám Giave, những mưu đồ đen tối và độc ác của vợ chồng Tênácđiê, sự ngây thơ trong trắng của Côdét, sự nhiệt tình hăng hái của Mariuýt… Tất cả đều được khắc họa một cách sinh động.', 1, 6, 3)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (2, N'Nhà Thờ Đức Bà Paris', 87000, 100, N'Nhà thờ Đức Bà Paris là tác phẩm tiêu biểu cho phong cách sáng tác theo khuynh hướng lãng mạn của Victor Hugo. Cũng nhờ thành công của tác phẩm mà ông được biết đến như một nhà văn nhân đạo, lãng mạn bậc nhất của nước Pháp.', 1, 6, 3)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (3, N'Ngày Cuối Cùng Của Một Tử Tù', 73000, 120, N'Tác phẩm ghi lại 24 giờ cuối cùng của cuộc đời một tử tù qua nhật ký của nhân vật xưng tôi – nhân vật không tên tuổi, lai lịch, không nguồn gốc tội lỗi, không ai biết anh ta phạm tội gì đến nỗi trở thành tử tù. Anh ta kể về không gian sinh tồn là nhà tù, những con người va chạm với anh ta trong 24 giờ đó là bạn tù, linh mục, cai ngục… và những người phụ nữ trong tâm tưởng gồm mẹ, vợ và con gái.', 1, 6, 3)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (4, N'Lao Động Và Biển Cả', 80000, 120, N'Lao động biển cả (Les Travailleurs de la mer) đã cuốn hút rất nhiều bạn đọc Việt Nam biết tiếng Pháp qua nhiều thế hệ. Đây không chỉ là một tác phẩm hiện thực phản ánh xã hội tư sản Pháp trong những ngày đầu của chế độ tư bản ở nước này.', 1, 6, 3)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (5, N'Thằng Cười', 132000, 100, N'Bộ tiểu thuyết Thằng cười của Victor Hugo đưa chúng ta đến với nước Anh của thế kỷ XVII, chủ yếu dưới các triều đại của dòng họ Xtiua. Giắc II và Annơ Xtiua', 1, 6, 3)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (6, N'Demian: Câu Chuyện Tuổi Trẻ Của Emil Sinclair', 116000, 100, N'Câu chuyện kể về Emil Sinclair, một cậu bé được sinh ra trong một gia đình trung lưu và bước tới ngưỡng tuổi trưởng thành. Cậu có những nhận thức đầu tiên về sự tồn tại của “hai thế giới”, đang băn khoăn giữa ánh sáng và bóng tối, giữa thiện và ác.', 6, 6, 6)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (7, N'Nhà Khổ Hạnh Và Gã Lang Thang', 110000, 100, N'Tập tu ở tu viện Mariabronn, Narcisse nổi bật bởi năng lực trí tuệ và văn hoá của mình. Người ta giao phó cho thầy cậu học sinh Goldmund mà thân sinh cậu ta muốn định phận làm một tu sĩ: để chuộc tội cho cuộc sống xáo động trong quá khứ của thân mẫu cậu. Narcisse kết bạn với chú em thông minh ấy. Thầy cảm nhận khuynh hướng của cậu không phải ở tu viện, và giúp cậu chọn con đường đi.', 12, 6, 6)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (8, N'Siddhartha', 45000, 130, N'Câu chuyện lấy thời điểm đức Phật còn tại thế, nói về một chàng thanh niên rời gia đình đi tìm giác ngộ. Dù được gặp Phật, dù bạn đồng hành đã gia nhập tăng đoàn, nhưng chàng thanh niên Siddhartha nhất quyết đi theo con đường của mình.', 8, 7, 6)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (9, N'Ông Già Và Biển Cả', 30000, 130, N'Ông Già Và Biển Cả (tên tiếng Anh: The Old Man and the Sea) là một tiểu thuyết ngắn được Ernest Hemingway viết ở Cuba năm 1951 và xuất bản năm 1952. Tác phẩm là truyện ngắn dạng viễn tưởng và là một trong những đỉnh cao trong sự nghiệp sáng tác của nhà văn, đoạt giải Pulitzer năm 1953.', 12, 3, 1)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (10, N'Giã Từ Vũ Khí', 44000, 130, N'Giã Từ Vũ Khí là một tiểu thuyết bán tự truyện của nhà văn Ernest Hemingway viết vào năm 1929. Câu chuyện được dẫn dắt qua lời kể của Trung úy Frederic Henry, từ một chàng trai người Mỹ với nhiều hoài bão trong cuộc sống muốn tìm cảm giác mạnh nên đã đầu quân vào quân đội Ý.', 6, 9, 1)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (11, N'Hội Hè Miên Man', 55000, 120, N'Tận sau khi đã qua đời, Hemingway vẫn không thôi làm say mê người đọc và tiếp tục ấn định cái nhìn không thể bắt chước về văn chương và con người. Xuất bản năm 1964, vài năm sau cái chết gây náo động của ông, Hội hè miên man không chỉ là cuốn hồi ký nhà văn, nó còn giống như một bữa tiệc chữ nghĩa với cách thức gia giảm hàm lượng và mùi vị chỉ Hemingway nắm được bí quyết', 1, 6, 1)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (12, N'Truyện cực ngắn của E. Hemingway', 110000, 100, N'Trong thời đại chúng ta là một trong những tác phẩm lạ nhất thế giới, cứ như là những mảnh ký ức, những mảnh tâm trạng ? những thoáng chốc hiện sinh của đời người được lắp ghép bất định, mãi mãi dang dở, mãi mãi chưa nói hết. Và những truyện ngắn khác của E. Hemingway trong tuyển tập này cũng là những mảnh vỡ như vậy', 1, 6, 1)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (13, N'Nhà Đầu Tư Thông Minh', 128000, 100, N'Là nhà tư vấn đầu tư vĩ đại nhất của thế kỷ 20, Benjamin Graham đã giảng dạy và truyền cảm hứng cho nhiều người trên khắp thế giới. Triết lý “đầu tư theo giá trị“ của Graham, bảo vệ nhà đầu tư khỏi những sai lầm lớn và dạy anh ta phát triển các chiến lược dài hạn, đã khiến Nhà đầu tư thông minh trở thành cẩm nang của thị trường chứng khoán kể từ lần xuất bản đầu tiên vào năm 1949.', 10, 11, 7)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (14, N'Phân Tích Chứng Khoán', 122000, 100, N'Phân Tích Chứng Khoán là một trong những cuốn sách tài chính có ảnh hưởng nhất thế giới từng được viết ra. Với hơn một triệu bản được bán ra thông qua năm phiên bản trước, Phân tích chứng khoán đã cung cấp cho các thế hệ nhà đầu tư những triết lý và kỹ thuật đầu tư vô cùng giá trị của Benjamin Graham và David L. Dodd.', 10, 11, 7)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (15, N'The Interpretation of Financial Statements', 120000, 100, N'Khối lượng kiến thức trong quyển sách này này là những hướng dẫn vượt thời gian của Graham, mang tính diễn giải và giúp người đọc hiểu sâu về báo cáo tài chính.', 10, 11, 7)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (16, N'Chúa Tể Những Chiếc Nhẫn: Nhà Vua Trở Về (Tái Bản)', 131000, 100, N'Mọi ngả đường dồn dập về một đích.', 2, 6, 2)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (17, N'Chúa Tể Những Chiếc Nhẫn: Đoàn Hô Nhẫn (Tái Bản)', 125000, 100, N'Tập đại thành Tiểu thuyết kỳ ảo của J.R.R. Tolkien', 2, 6, 2)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (18, N'Chúa Tể Những Chiếc Nhẫn: Hai Tòa Tháp (Tái Bản)', 120000, 100, N'Chúa Tể Những Chiếc Nhẫn - Hai Tòa Tháp', 2, 6, 2)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (19, N'Tắt Đèn', 33000, 100, N'Tắt đèn của nhà văn Ngô Tất Tố phản ánh rất chân thực cuộc sống khốn khổ của tầng lớp nông dân Việt Nam đầu thế kỷ XX dưới ách đô hộ của thực dân Pháp. Tác phẩm xoay quanh nhân vật chị Dậu và gia đình – một điển hình của cuộc sống bần cùng hóa sưu cao thuế nặng mà chế độ thực dân áp đặt lên xã hội Việt Nam.', 1, 5, 4)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (20, N'Việc Làng', 32000, 110, N'Ra đời cách đây ba phần tư thế kỷ, Phóng sự Việc làng giới thiệu với bạn đọc nhất là thế hệ trẻ và với độc giả ở các vùng miền khác trong cả nước ta về “cuộc đời và con người trong bức tranh làng quê Bắc Bộ”.', 1, 5, 4)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (21, N'Lều Chõng', 57000, 120, N'Lều chõng đã thực hiện “một tua du lịch” sinh động, thú vị, giúp các thế hệ hậu sinh, lội ngược dòng thời gian để tiếp cận và khám phá về Lều chõng, khu vực có ý nghĩa đặc biệt, không chỉ là chuyện văn chương, chữ nghĩa mà còn gắn bó mật thiết đến vận mệnh đại sự của quốc gia, đến sự tồn vong, hưng thịnh của đất nước.', 1, 5, 4)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (22, N'Tập Án Cái Đình', 38000, 120, N'Tập Án Cái Đình là một thiên phóng sự đăng lần đầu tiên trên báo “Con Ong” từ số 18/10/1939. Tập án cái đình viết về những hủ tục ở chốn đình trung, đặc biệt là những lễ nghi phiền phức, hủ bại. Ở đây thiên Phóng sự nghiêng về mặt miêu tả những phong tục, nói cho đúng hơn là những hủ tục kỳ quái được duy trì ở nông thôn. Nó cung cấp được nhiều tài liệu về mặt xã hội học.', 1, 5, 4)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (23, N'Nhà Giả Kim', 55000, 110, N'Nhà giả kim thật sự là một tác phẩm tuyệt vời. Cái cách mà tác giả đưa người đọc đi theo hành trình của Santiago tìm kho báu rất thú vị, nó làm cho người đọc có cảm giác như chính mình đang tham gia vào chuyến phưu lưu ấy. Bài học rút ra “Hãy cứ đam mê, hãy cứ dại khờ”, lắng nghe trái tim mình để đạt được ước mơ to lớn! Xin đừng nản chí các bạn trẻ, nhưng hãy chọn đúng những gì mà bạn đã chọn!', 12, 5, 5)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (24, N'Bên Bờ Sông Piedra Tôi Ngồi Khóc', 127000, 120, N'Anh và cô lớn lên bên nhau. Rồi những ước mơ đã đưa anh đi trải nghiệm thế giới rộng lớn. Pilar ở lại quê nhà, ngỡ sẽ sống mãi ở đó cuộc đời tuần tự như bao người. Nhưng có một kỷ vật khiến cho tâm tư anh dù đi nơi đâu cũng hướng về chốn cũ. Và một ngày, anh dắt cô đi, trao cho cô tình yêu giữ trong tim nhiều năm tháng.', 5, 2, 5)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (25, N'Điệp Viên', 49000, 100, N'Đến Paris với hai bàn tay trắng, trong vòng vài tháng, Mata Hari trở thành bóng hồng nổi tiếng nhất thành phố phù hoa.Trong vai nữ vũ công, cô khiến người ta phải sững sờ và mê đắm. Trong vai một cô điếm hạng sang, cô quyến rũ những nhân vật giàu có và tiếng tăm bậc nhất thời đó.', 6, 2, 5)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (26, N'13 Nguyên Tắc Nghĩ Giàu Làm Giàu', 80000, 120, N'13 nguyên tắc nghĩ giàu làm giàu (Think And Grow Rich) là một trong số những tác phẩm thành công nhất của Napoleon Hill. Cuốn sách nổi tiếng đến mức tham quan bất kì cửa hàng sách nào ở Mỹ, bạn sẽ tìm thấy cuốn sách này trên giá sách kinh doanh. Bill Brooks đã không ngần ngại khen tặng: “Ấn bản gốc của Napoleon Hill đã làm thay đổi cả thế kỉ XX của chúng ta.', 10, 11, 8)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (27, N'Chiến Thắng Con Quỷ Trong Bạn', 58000, 110, N'Chiến Thắng Con Quỷ Trong Bạn là cuộc trò chuyện của Napoleon Hill và Con Quỷ. Sau bao nhiêu năm miệt mài nghiên cứu cuối cùng ông cũng phát hiện ra Con Quỷ, bắt nó phải thú tội và tiết lộ những sự thật kinh hoàng về nơi nó sống, cách nó kiểm soát tâm trí con người và cách để con người chiến thắng được nó.', 10, 6, 8)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (28, N'Những Nguyên Tắc Vàng Của Napoleon Hill', 51000, 120, N'Những nguyên tắc vàng của Napoleon Hill tập hợp những bài viết của ông trong khoảng thời gian từ năm 1919 đến năm 1923. “Những nguyên tắc vàng” này chính là chiếc chìa khóa hữu dụng trong mọi thời đại, đưa độc giả đến với thành công bằng phương pháp mang tính thực tiễn cao.', 10, 6, 8)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (29, N'Tư Duy Tích Cực Để Thành Công', 81000, 120, N'“Tư duy tích cực để thành công” khuyến khích độc giả nhận ra giá trị và cơ hội của thời gian, lợi ích của kỷ luật tự giác, sáng kiến cá nhân, cùng nguyên tắc và sức mạnh của trí tưởng tượng. Không ép buộc bạn phải thay đổi đột ngột, mà với văn phong nhẹ nhàng, sâu sắc, Napoleon Hill cùng các cộng sự kỳ vọng bạn sẽ có được tầm nhìn tươi mới về thành công, và quan trọng hơn cả, luôn giữ một thái độ tích cực và đầy nhiệt thành với cuộc sống tươi đẹp.', 10, 6, 8)
INSERT [dbo].[SACH] ([masach], [tensach], [gia], [soluong], [mota], [macd], [manxb], [matg]) VALUES (30, N'Kế hoạch làm giàu 365 ngày', 57000, 120, N'Kế hoạch làm giàu 365 ngày (Positive Action Plan) là 365 câu trích dẫn của Napoleon Hill dành cho 365 ngày trong năm. Mỗi câu trích dẫn lại có một thông điệp truyền cảm hứng đi kèm để bạn đọc dễ dàng tiếp nhận và áp dụng những quan niềm đầy quyền năng đó vào cuộc sống hàng ngày.', 10, 6, 8)
GO
SET IDENTITY_INSERT [dbo].[TACGIA] ON 

INSERT [dbo].[TACGIA] ([matg], [tentg]) VALUES (1, N'Ernest Miller Hemingway')
INSERT [dbo].[TACGIA] ([matg], [tentg]) VALUES (2, N'John Ronald Reuel Tolkien')
INSERT [dbo].[TACGIA] ([matg], [tentg]) VALUES (3, N'Victor Hugo')
INSERT [dbo].[TACGIA] ([matg], [tentg]) VALUES (4, N'Ngô Tất Tố')
INSERT [dbo].[TACGIA] ([matg], [tentg]) VALUES (5, N'Paulo Coelho')
INSERT [dbo].[TACGIA] ([matg], [tentg]) VALUES (6, N'Hermann Hesse')
INSERT [dbo].[TACGIA] ([matg], [tentg]) VALUES (7, N'Benjamin Graham')
INSERT [dbo].[TACGIA] ([matg], [tentg]) VALUES (8, N'Napoleon Hill')
SET IDENTITY_INSERT [dbo].[TACGIA] OFF
GO
INSERT [dbo].[TAIKHOAN] ([tentk], [matkhau], [hoten], [chucvu], [gioitinh], [ngaysinh]) VALUES (N'baole1010                     ', N'101000                        ', N'Lê Quốc Bảo', N'Quản lý', N'Nam', CAST(N'2000-10-10' AS Date))
INSERT [dbo].[TAIKHOAN] ([tentk], [matkhau], [hoten], [chucvu], [gioitinh], [ngaysinh]) VALUES (N'taivo                         ', N'123                           ', N'Võ Hồ Tấn Tài', N'Quản lý', N'Nam', CAST(N'2000-12-18' AS Date))
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [fk_5] FOREIGN KEY([mahd])
REFERENCES [dbo].[HOADON] ([mahd])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [fk_5]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [fk_6] FOREIGN KEY([masach])
REFERENCES [dbo].[SACH] ([masach])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [fk_6]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk_4] FOREIGN KEY([nguoiban])
REFERENCES [dbo].[TAIKHOAN] ([tentk])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk_4]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [fk_1] FOREIGN KEY([macd])
REFERENCES [dbo].[CHUDE] ([macd])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [fk_1]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [fk_2] FOREIGN KEY([manxb])
REFERENCES [dbo].[NHAXUATBAN] ([manxb])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [fk_2]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [fk_3] FOREIGN KEY([matg])
REFERENCES [dbo].[TACGIA] ([matg])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [fk_3]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [chk_gt] CHECK  (([gioitinh]=N'Nam' OR [gioitinh]=N'Nữ'))
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [chk_gt]
GO

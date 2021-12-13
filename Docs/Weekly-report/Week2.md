# Báo cáo tuần 2

## Thêm tính năng chơi nhiều người

Nhóm dùng PhotonEngine để hỗ trợ cho việc xây dựng tính ăng này. Hiện đã có chức năng tạo phòng, chơi nhiều người.

## Thêm tính năng "hồi sinh" khi nhân vật chết

Sau khi chết (hoặc bắt đầu trận mới), nhân vật sẽ được chuyển đến một trong số các địa điểm được tạo sẵn trong game (ngẫu nhiên).

Đây là tính năng mới xuất hiện khi đang làm bản đồ online. Nhưng có một lỗi khó hiểu, nhóm đang tìm cách khắc phục.

## Xây dựng (lại) bản đồ

Trong quá trình chơi, nhóm nhận thấy fps bị giảm nghiêm trọng. Nguyên nhân là do dùng quá nhiều prefab dẫn đến các chỉ số `batches`, `vertexes`, `triangles`... tăng cao một cách không cần thiết.

Để giải quyết chuyện này, mọi người đã thống nhất xây dựng một bản đồ khác với các khối liên mạch, bỏ hướng xây dựng theo kiểu xếp từng viên gạch như ở bản đồ cũ. Hiệu năng cải thiện đáng kể, ví dụ:

| Chỉ số | Bản đồ cũ | Bản đồ mới |
| --- | --- | --- |
| batches | 62.4 k | 183 |
| vertexes | 14.3 m | 167.7 k |
| triangles | 10.5 m | 182.2 k |
| **fps** | 11 | 160 |

Công việc vẫn đang trong quá trình hoàn thiện ở nhánh [redesign-map](https://github.com/nnchaubui/SE06-19.2/tree/feature/redesign-map)

## Một số việc khác

- Tạo bản đồ thu nhỏ cho người chơi ở góc trên phải.
- Thanh máu màu xanh nằm ở góc dưới trái.

## Kế hoạch tuần tới

Giải quyết các vấn đề đang thảo luận ở [issue](https://github.com/nnchaubui/SE06-19.2/issues). Cụ thể:

- Mở rộng bản đồ dựa trên bản đồ MỚI
- Sửa lại giao diện trò chơi (thanh máu, màn hình hướng dẫn chơi game, màn hình chọn phòng...).
- Tìm lí do cho bug lạ [#20](https://github.com/nnchaubui/SE06-19.2/issues/20).

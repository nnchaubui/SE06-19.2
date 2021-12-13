# Báo cáo tuần 2

## Thêm tính năng chơi nhiều người

Dùng photon-2? Hình như vậy.

## Thêm tính năng "hồi sinh" khi nhân vật chết

Một tính năng mới được xuất hiện khi đang làm map online. Nhưng có một lỗi khó hiểu.

## Xây dựng (lại) bản đồ

Trong quá trình chơi, nhóm nhận thấy fps bị giảm nghiêm trọng. Nguyên nhân là do dùng quá nhiều prefab dẫn đến các chỉ số `batches`, `vertexes`, `triangles`... tăng cao một cách không cần thiết.

Để giải quyết chuyện này, mọi người đã thống nhất xây dựng một bản đồ khác với các khối liên mạch, bỏ hướng xây dựng theo kiểu xếp từng viên gạch như ở map cũ. Hiện tại đã giảm được số lượng `batches` xuống 200 lần.

Công việc vẫn đang trong quá trình hoàn thiện ở nhánh [redesign-map](https://github.com/nnchaubui/SE06-19.2/tree/feature/redesign-map)

## Một số việc khác

Thanh máu màu xanh nằm ở góc dưới trái.

## Kế hoạch tuần tới

- Mở rộng map dựa trên map MỚI
- Tùy chỉnh giao diện trò chơi.
- Thử tìm lí do cho bug lạ.
- ...

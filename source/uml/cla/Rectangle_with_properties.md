![A UML diagram for the Rectangle class ([text version](./uml/cla/Rectangle_with_properties.txt))](data:image/svg+xml;base64,PHN2ZyBhcmlhLXJvbGVkZXNjcmlwdGlvbj0iY2xhc3NEaWFncmFtIiByb2xlPSJncmFwaGljcy1kb2N1bWVudCBkb2N1bWVudCIgdmlld0JveD0iMCAwIDIwNi42NTYyNSAxNDMiIHN0eWxlPSJtYXgtd2lkdGg6IDIwNi42NTZweDsgYmFja2dyb3VuZC1jb2xvcjogd2hpdGU7IiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMTAwJSIgaWQ9Im15LXN2ZyI+PHN0eWxlPiNteS1zdmd7Zm9udC1mYW1pbHk6InRyZWJ1Y2hldCBtcyIsdmVyZGFuYSxhcmlhbCxzYW5zLXNlcmlmO2ZvbnQtc2l6ZToxNnB4O2ZpbGw6IzMzMzt9I215LXN2ZyAuZXJyb3ItaWNvbntmaWxsOiM1NTIyMjI7fSNteS1zdmcgLmVycm9yLXRleHR7ZmlsbDojNTUyMjIyO3N0cm9rZTojNTUyMjIyO30jbXktc3ZnIC5lZGdlLXRoaWNrbmVzcy1ub3JtYWx7c3Ryb2tlLXdpZHRoOjJweDt9I215LXN2ZyAuZWRnZS10aGlja25lc3MtdGhpY2t7c3Ryb2tlLXdpZHRoOjMuNXB4O30jbXktc3ZnIC5lZGdlLXBhdHRlcm4tc29saWR7c3Ryb2tlLWRhc2hhcnJheTowO30jbXktc3ZnIC5lZGdlLXBhdHRlcm4tZGFzaGVke3N0cm9rZS1kYXNoYXJyYXk6Mzt9I215LXN2ZyAuZWRnZS1wYXR0ZXJuLWRvdHRlZHtzdHJva2UtZGFzaGFycmF5OjI7fSNteS1zdmcgLm1hcmtlcntmaWxsOiMzMzMzMzM7c3Ryb2tlOiMzMzMzMzM7fSNteS1zdmcgLm1hcmtlci5jcm9zc3tzdHJva2U6IzMzMzMzMzt9I215LXN2ZyBzdmd7Zm9udC1mYW1pbHk6InRyZWJ1Y2hldCBtcyIsdmVyZGFuYSxhcmlhbCxzYW5zLXNlcmlmO2ZvbnQtc2l6ZToxNnB4O30jbXktc3ZnIGcuY2xhc3NHcm91cCB0ZXh0e2ZpbGw6IzkzNzBEQjtzdHJva2U6bm9uZTtmb250LWZhbWlseToidHJlYnVjaGV0IG1zIix2ZXJkYW5hLGFyaWFsLHNhbnMtc2VyaWY7Zm9udC1zaXplOjEwcHg7fSNteS1zdmcgZy5jbGFzc0dyb3VwIHRleHQgLnRpdGxle2ZvbnQtd2VpZ2h0OmJvbGRlcjt9I215LXN2ZyAubm9kZUxhYmVsLCNteS1zdmcgLmVkZ2VMYWJlbHtjb2xvcjojMTMxMzAwO30jbXktc3ZnIC5lZGdlTGFiZWwgLmxhYmVsIHJlY3R7ZmlsbDojRUNFQ0ZGO30jbXktc3ZnIC5sYWJlbCB0ZXh0e2ZpbGw6IzEzMTMwMDt9I215LXN2ZyAuZWRnZUxhYmVsIC5sYWJlbCBzcGFue2JhY2tncm91bmQ6I0VDRUNGRjt9I215LXN2ZyAuY2xhc3NUaXRsZXtmb250LXdlaWdodDpib2xkZXI7fSNteS1zdmcgLm5vZGUgcmVjdCwjbXktc3ZnIC5ub2RlIGNpcmNsZSwjbXktc3ZnIC5ub2RlIGVsbGlwc2UsI215LXN2ZyAubm9kZSBwb2x5Z29uLCNteS1zdmcgLm5vZGUgcGF0aHtmaWxsOiNFQ0VDRkY7c3Ryb2tlOiM5MzcwREI7c3Ryb2tlLXdpZHRoOjFweDt9I215LXN2ZyAuZGl2aWRlcntzdHJva2U6IzkzNzBEQjtzdHJva2Utd2lkdGg6MTt9I215LXN2ZyBnLmNsaWNrYWJsZXtjdXJzb3I6cG9pbnRlcjt9I215LXN2ZyBnLmNsYXNzR3JvdXAgcmVjdHtmaWxsOiNFQ0VDRkY7c3Ryb2tlOiM5MzcwREI7fSNteS1zdmcgZy5jbGFzc0dyb3VwIGxpbmV7c3Ryb2tlOiM5MzcwREI7c3Ryb2tlLXdpZHRoOjE7fSNteS1zdmcgLmNsYXNzTGFiZWwgLmJveHtzdHJva2U6bm9uZTtzdHJva2Utd2lkdGg6MDtmaWxsOiNFQ0VDRkY7b3BhY2l0eTowLjU7fSNteS1zdmcgLmNsYXNzTGFiZWwgLmxhYmVse2ZpbGw6IzkzNzBEQjtmb250LXNpemU6MTBweDt9I215LXN2ZyAucmVsYXRpb257c3Ryb2tlOiMzMzMzMzM7c3Ryb2tlLXdpZHRoOjE7ZmlsbDpub25lO30jbXktc3ZnIC5kYXNoZWQtbGluZXtzdHJva2UtZGFzaGFycmF5OjM7fSNteS1zdmcgLmRvdHRlZC1saW5le3N0cm9rZS1kYXNoYXJyYXk6MSAyO30jbXktc3ZnICNjb21wb3NpdGlvblN0YXJ0LCNteS1zdmcgLmNvbXBvc2l0aW9ue2ZpbGw6IzMzMzMzMyFpbXBvcnRhbnQ7c3Ryb2tlOiMzMzMzMzMhaW1wb3J0YW50O3N0cm9rZS13aWR0aDoxO30jbXktc3ZnICNjb21wb3NpdGlvbkVuZCwjbXktc3ZnIC5jb21wb3NpdGlvbntmaWxsOiMzMzMzMzMhaW1wb3J0YW50O3N0cm9rZTojMzMzMzMzIWltcG9ydGFudDtzdHJva2Utd2lkdGg6MTt9I215LXN2ZyAjZGVwZW5kZW5jeVN0YXJ0LCNteS1zdmcgLmRlcGVuZGVuY3l7ZmlsbDojMzMzMzMzIWltcG9ydGFudDtzdHJva2U6IzMzMzMzMyFpbXBvcnRhbnQ7c3Ryb2tlLXdpZHRoOjE7fSNteS1zdmcgI2RlcGVuZGVuY3lTdGFydCwjbXktc3ZnIC5kZXBlbmRlbmN5e2ZpbGw6IzMzMzMzMyFpbXBvcnRhbnQ7c3Ryb2tlOiMzMzMzMzMhaW1wb3J0YW50O3N0cm9rZS13aWR0aDoxO30jbXktc3ZnICNleHRlbnNpb25TdGFydCwjbXktc3ZnIC5leHRlbnNpb257ZmlsbDp0cmFuc3BhcmVudCFpbXBvcnRhbnQ7c3Ryb2tlOiMzMzMzMzMhaW1wb3J0YW50O3N0cm9rZS13aWR0aDoxO30jbXktc3ZnICNleHRlbnNpb25FbmQsI215LXN2ZyAuZXh0ZW5zaW9ue2ZpbGw6dHJhbnNwYXJlbnQhaW1wb3J0YW50O3N0cm9rZTojMzMzMzMzIWltcG9ydGFudDtzdHJva2Utd2lkdGg6MTt9I215LXN2ZyAjYWdncmVnYXRpb25TdGFydCwjbXktc3ZnIC5hZ2dyZWdhdGlvbntmaWxsOnRyYW5zcGFyZW50IWltcG9ydGFudDtzdHJva2U6IzMzMzMzMyFpbXBvcnRhbnQ7c3Ryb2tlLXdpZHRoOjE7fSNteS1zdmcgI2FnZ3JlZ2F0aW9uRW5kLCNteS1zdmcgLmFnZ3JlZ2F0aW9ue2ZpbGw6dHJhbnNwYXJlbnQhaW1wb3J0YW50O3N0cm9rZTojMzMzMzMzIWltcG9ydGFudDtzdHJva2Utd2lkdGg6MTt9I215LXN2ZyAjbG9sbGlwb3BTdGFydCwjbXktc3ZnIC5sb2xsaXBvcHtmaWxsOiNFQ0VDRkYhaW1wb3J0YW50O3N0cm9rZTojMzMzMzMzIWltcG9ydGFudDtzdHJva2Utd2lkdGg6MTt9I215LXN2ZyAjbG9sbGlwb3BFbmQsI215LXN2ZyAubG9sbGlwb3B7ZmlsbDojRUNFQ0ZGIWltcG9ydGFudDtzdHJva2U6IzMzMzMzMyFpbXBvcnRhbnQ7c3Ryb2tlLXdpZHRoOjE7fSNteS1zdmcgLmVkZ2VUZXJtaW5hbHN7Zm9udC1zaXplOjExcHg7bGluZS1oZWlnaHQ6aW5pdGlhbDt9I215LXN2ZyAuY2xhc3NUaXRsZVRleHR7dGV4dC1hbmNob3I6bWlkZGxlO2ZvbnQtc2l6ZToxOHB4O2ZpbGw6IzMzMzt9I215LXN2ZyA6cm9vdHstLW1lcm1haWQtZm9udC1mYW1pbHk6InRyZWJ1Y2hldCBtcyIsdmVyZGFuYSxhcmlhbCxzYW5zLXNlcmlmO308L3N0eWxlPjxnPjxkZWZzPjxtYXJrZXIgb3JpZW50PSJhdXRvIiBtYXJrZXJIZWlnaHQ9IjI0MCIgbWFya2VyV2lkdGg9IjE5MCIgcmVmWT0iNyIgcmVmWD0iMTgiIGNsYXNzPSJtYXJrZXIgYWdncmVnYXRpb24gY2xhc3NEaWFncmFtIiBpZD0ibXktc3ZnX2NsYXNzRGlhZ3JhbS1hZ2dyZWdhdGlvblN0YXJ0Ij48cGF0aCBkPSJNIDE4LDcgTDksMTMgTDEsNyBMOSwxIFoiLz48L21hcmtlcj48L2RlZnM+PGRlZnM+PG1hcmtlciBvcmllbnQ9ImF1dG8iIG1hcmtlckhlaWdodD0iMjgiIG1hcmtlcldpZHRoPSIyMCIgcmVmWT0iNyIgcmVmWD0iMSIgY2xhc3M9Im1hcmtlciBhZ2dyZWdhdGlvbiBjbGFzc0RpYWdyYW0iIGlkPSJteS1zdmdfY2xhc3NEaWFncmFtLWFnZ3JlZ2F0aW9uRW5kIj48cGF0aCBkPSJNIDE4LDcgTDksMTMgTDEsNyBMOSwxIFoiLz48L21hcmtlcj48L2RlZnM+PGRlZnM+PG1hcmtlciBvcmllbnQ9ImF1dG8iIG1hcmtlckhlaWdodD0iMjQwIiBtYXJrZXJXaWR0aD0iMTkwIiByZWZZPSI3IiByZWZYPSIxOCIgY2xhc3M9Im1hcmtlciBleHRlbnNpb24gY2xhc3NEaWFncmFtIiBpZD0ibXktc3ZnX2NsYXNzRGlhZ3JhbS1leHRlbnNpb25TdGFydCI+PHBhdGggZD0iTSAxLDcgTDE4LDEzIFYgMSBaIi8+PC9tYXJrZXI+PC9kZWZzPjxkZWZzPjxtYXJrZXIgb3JpZW50PSJhdXRvIiBtYXJrZXJIZWlnaHQ9IjI4IiBtYXJrZXJXaWR0aD0iMjAiIHJlZlk9IjciIHJlZlg9IjEiIGNsYXNzPSJtYXJrZXIgZXh0ZW5zaW9uIGNsYXNzRGlhZ3JhbSIgaWQ9Im15LXN2Z19jbGFzc0RpYWdyYW0tZXh0ZW5zaW9uRW5kIj48cGF0aCBkPSJNIDEsMSBWIDEzIEwxOCw3IFoiLz48L21hcmtlcj48L2RlZnM+PGRlZnM+PG1hcmtlciBvcmllbnQ9ImF1dG8iIG1hcmtlckhlaWdodD0iMjQwIiBtYXJrZXJXaWR0aD0iMTkwIiByZWZZPSI3IiByZWZYPSIxOCIgY2xhc3M9Im1hcmtlciBjb21wb3NpdGlvbiBjbGFzc0RpYWdyYW0iIGlkPSJteS1zdmdfY2xhc3NEaWFncmFtLWNvbXBvc2l0aW9uU3RhcnQiPjxwYXRoIGQ9Ik0gMTgsNyBMOSwxMyBMMSw3IEw5LDEgWiIvPjwvbWFya2VyPjwvZGVmcz48ZGVmcz48bWFya2VyIG9yaWVudD0iYXV0byIgbWFya2VySGVpZ2h0PSIyOCIgbWFya2VyV2lkdGg9IjIwIiByZWZZPSI3IiByZWZYPSIxIiBjbGFzcz0ibWFya2VyIGNvbXBvc2l0aW9uIGNsYXNzRGlhZ3JhbSIgaWQ9Im15LXN2Z19jbGFzc0RpYWdyYW0tY29tcG9zaXRpb25FbmQiPjxwYXRoIGQ9Ik0gMTgsNyBMOSwxMyBMMSw3IEw5LDEgWiIvPjwvbWFya2VyPjwvZGVmcz48ZGVmcz48bWFya2VyIG9yaWVudD0iYXV0byIgbWFya2VySGVpZ2h0PSIyNDAiIG1hcmtlcldpZHRoPSIxOTAiIHJlZlk9IjciIHJlZlg9IjYiIGNsYXNzPSJtYXJrZXIgZGVwZW5kZW5jeSBjbGFzc0RpYWdyYW0iIGlkPSJteS1zdmdfY2xhc3NEaWFncmFtLWRlcGVuZGVuY3lTdGFydCI+PHBhdGggZD0iTSA1LDcgTDksMTMgTDEsNyBMOSwxIFoiLz48L21hcmtlcj48L2RlZnM+PGRlZnM+PG1hcmtlciBvcmllbnQ9ImF1dG8iIG1hcmtlckhlaWdodD0iMjgiIG1hcmtlcldpZHRoPSIyMCIgcmVmWT0iNyIgcmVmWD0iMTMiIGNsYXNzPSJtYXJrZXIgZGVwZW5kZW5jeSBjbGFzc0RpYWdyYW0iIGlkPSJteS1zdmdfY2xhc3NEaWFncmFtLWRlcGVuZGVuY3lFbmQiPjxwYXRoIGQ9Ik0gMTgsNyBMOSwxMyBMMTQsNyBMOSwxIFoiLz48L21hcmtlcj48L2RlZnM+PGRlZnM+PG1hcmtlciBvcmllbnQ9ImF1dG8iIG1hcmtlckhlaWdodD0iMjQwIiBtYXJrZXJXaWR0aD0iMTkwIiByZWZZPSI3IiByZWZYPSIxMyIgY2xhc3M9Im1hcmtlciBsb2xsaXBvcCBjbGFzc0RpYWdyYW0iIGlkPSJteS1zdmdfY2xhc3NEaWFncmFtLWxvbGxpcG9wU3RhcnQiPjxjaXJjbGUgcj0iNiIgY3k9IjciIGN4PSI3IiBmaWxsPSJ0cmFuc3BhcmVudCIgc3Ryb2tlPSJibGFjayIvPjwvbWFya2VyPjwvZGVmcz48ZGVmcz48bWFya2VyIG9yaWVudD0iYXV0byIgbWFya2VySGVpZ2h0PSIyNDAiIG1hcmtlcldpZHRoPSIxOTAiIHJlZlk9IjciIHJlZlg9IjEiIGNsYXNzPSJtYXJrZXIgbG9sbGlwb3AgY2xhc3NEaWFncmFtIiBpZD0ibXktc3ZnX2NsYXNzRGlhZ3JhbS1sb2xsaXBvcEVuZCI+PGNpcmNsZSByPSI2IiBjeT0iNyIgY3g9IjciIGZpbGw9InRyYW5zcGFyZW50IiBzdHJva2U9ImJsYWNrIi8+PC9tYXJrZXI+PC9kZWZzPjxnIGNsYXNzPSJyb290Ij48ZyBjbGFzcz0iY2x1c3RlcnMiLz48ZyBjbGFzcz0iZWRnZVBhdGhzIi8+PGcgY2xhc3M9ImVkZ2VMYWJlbHMiLz48ZyBjbGFzcz0ibm9kZXMiPjxnIHRyYW5zZm9ybT0idHJhbnNsYXRlKDEwMy4zMjgxMjUsIDcxLjUpIiBkYXRhLWlkPSJSZWN0YW5nbGUiIGRhdGEtbm9kZT0idHJ1ZSIgaWQ9ImNsYXNzSWQtUmVjdGFuZ2xlLTAiIGNsYXNzPSJub2RlIGRlZmF1bHQiPjxyZWN0IGhlaWdodD0iMTI3IiB3aWR0aD0iMTkwLjY1NjI1IiB5PSItNjMuNSIgeD0iLTk1LjMyODEyNSIgY2xhc3M9Im91dGVyIHRpdGxlLXN0YXRlIiBzdHlsZT0iIi8+PGxpbmUgeTI9Ii0zMi41IiB5MT0iLTMyLjUiIHgyPSI5NS4zMjgxMjUiIHgxPSItOTUuMzI4MTI1IiBjbGFzcz0iZGl2aWRlciIvPjxsaW5lIHkyPSIyOS41IiB5MT0iMjkuNSIgeDI9Ijk1LjMyODEyNSIgeDE9Ii05NS4zMjgxMjUiIGNsYXNzPSJkaXZpZGVyIi8+PGcgY2xhc3M9ImxhYmVsIj48dGV4dCBzdHlsZT0iIj48dHNwYW4gY2xhc3M9InRpdGxlLXJvdyIgeD0iMCIgZHk9IjFlbSIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSIvPjwvdGV4dD48dGV4dCB0cmFuc2Zvcm09InRyYW5zbGF0ZSggLTM2LjcxMDkzNzUsIC01NikiIGNsYXNzPSJjbGFzc1RpdGxlIiBzdHlsZT0iIj48dHNwYW4gY2xhc3M9InRpdGxlLXJvdyIgeD0iMCIgZHk9IjFlbSIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+UmVjdGFuZ2xlPC90c3Bhbj48L3RleHQ+PHRleHQgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoIC04Ny44MjgxMjUsIC0yMSkiIHN0eWxlPSIiPjx0c3BhbiBjbGFzcz0idGl0bGUtcm93IiB4PSIwIiBkeT0iMWVtIiB4bWw6c3BhY2U9InByZXNlcnZlIj4rIMKrcHJvcGVydHnCuyBXaWR0aDogaW50PC90c3Bhbj48L3RleHQ+PHRleHQgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoIC04Ny44MjgxMjUsIDIpIiBzdHlsZT0iIj48dHNwYW4gY2xhc3M9InRpdGxlLXJvdyIgeD0iMCIgZHk9IjFlbSIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+KyDCq3Byb3BlcnR5wrsgTGVuZ3RoOiBpbnQ8L3RzcGFuPjwvdGV4dD48dGV4dCB0cmFuc2Zvcm09InRyYW5zbGF0ZSggLTg3LjgyODEyNSwgMzcpIiBzdHlsZT0iIj48dHNwYW4gY2xhc3M9InRpdGxlLXJvdyIgeD0iMCIgZHk9IjFlbSIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+K0NvbXB1dGVBcmVhKCkgOiBpbnQ8L3RzcGFuPjwvdGV4dD48L2c+PC9nPjwvZz48L2c+PC9nPjwvc3ZnPg==  "class Rectangle{     + «property» Width: int     + «property» Length: int      + ComputeArea() int } ")
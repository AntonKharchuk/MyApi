# MyApi
![.NetV](https://img.shields.io/static/v1?style=badge&message=5.0&color=blueviolet&label=.Net) ![Api]( https://img.shields.io/static/v1?message=Api&color=yellow&label=) ![Forks](https://img.shields.io/github/forks/AntonKharchuk/PasswordsHash?style=social)

**MyApi** - an Api to search music on YouTube

## Description

## `Get` /videoinfo?VideoId={id}
	
:envelope: Response body
```C#
{
  "id": string,
  "userId": string,
  "userName": string,
  "channelId": string,
  "channelTitle": string,
  "videoId": string,
  "videoTitle": string
}
```

## `Get` /videosbyrequest?request={request}
	
:envelope: Response body

```C#
[
  {
    "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  }
]
```

## `Get` /artistbyrequest?artist={artist}
	
:envelope: Response body

```C#
[
  {
    "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  }
  ...
]
```

## `Get` /genresbyrequest
	
:envelope: Response body

```C#
[
	[
		{
			"channelTitle": string,
			"videoId": string,
			"videoTitle": string
		},
		...
	],
	[
		{
			"channelTitle": string,
			"videoId": string,
			"videoTitle": string
		},
		...
	]
	...
]
```

## `Get` /trendsbyrequest
	
:envelope: Response body

```C#
[
  {
    "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  },
  {
   "channelTitle": string,
    "videoId": string,
    "videoTitle": string
  }
]
```

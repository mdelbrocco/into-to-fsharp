// take a url as a string and if it starts with "https://"", remove it.
// e.g. "https://sample.com" -> "sample.com"
let removeHttps (url: string) =
    if url.StartsWith "https://" then url.Substring("https://".Length)
    else url

// take a url as a string and if it starts with "http://"", remove it.
// e.g. "http://sample.com" -> "sample.com"
let removeHttp (url: string) =
    if url.StartsWith "http://" then url.Substring("http://".Length)
    else url

// take a url and remove the query string
// e.g. "http://sample.com?someval=3" -> "http://sample.com"
let removeQueryString (url: string) =
    if url.IndexOf("?") > 0 then url.Substring(0, url.IndexOf("?"))
    else url

let simplifyUrl (url: string) =
    url
    |> removeHttp
    |> removeHttps
    |> removeQueryString